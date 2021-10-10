using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public enum GestureType
{
    RightHandIndexPoint,
    RightHandThumbsUp,
    RightHandStop,
    NewGesture,

}

[System.Serializable]
public struct Gesture
{
    public GestureType gestureType;
    public List<Vector3> fingerData;
}

[System.Serializable]
public class GestureDetector : MonoBehaviour
{
    [SerializeField] OVRSkeleton skeleton = null;
    [SerializeField] List<Gesture> gestures = new List<Gesture>();
    [SerializeField] float threshold = 0.1f;
    [SerializeField] TextMeshProUGUI text = null;

    List<OVRBone> fingerBones = new List<OVRBone>();
    Gesture previousGesture;

    public Transform RayCastPoint { get; private set; }

    bool isInitialized = false;

    public static Action<Gesture> NewGestureRecognizedEvent;

    IEnumerator Start()
    {
        yield return new WaitUntil(() => skeleton.IsInitialized == true);

        Initialize();
    }

    private void Update()
    {
        if (isInitialized)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SaveGesture();
            }

            Gesture currentGesture = RecognizeGesture();
            bool hasRecognized = !currentGesture.Equals(new Gesture());

            if (hasRecognized && currentGesture.Equals(previousGesture) == false)
            {
                text.text = currentGesture.gestureType.ToString();
                previousGesture = currentGesture;
                NewGestureRecognizedEvent?.Invoke(currentGesture);
            }
        }
    }

    void Initialize()
    {
        fingerBones = new List<OVRBone>(skeleton.Bones);
        previousGesture = new Gesture();

        foreach (var bone in skeleton.Bones)
        {
            if (bone.Id == OVRSkeleton.BoneId.Hand_IndexTip)
            {
                RayCastPoint = bone.Transform;
            }
        }

        isInitialized = true;
    }

    void SaveGesture()
    {
        Gesture gesture = new Gesture();
        gesture.gestureType = GestureType.NewGesture;
        List<Vector3> data = new List<Vector3>();

        foreach (var bone in fingerBones)
        {
            data.Add(skeleton.transform.InverseTransformPoint(bone.Transform.position));
        }

        gesture.fingerData = data;
        gestures.Add(gesture);
    }

    Gesture RecognizeGesture()
    {
        Gesture currentGesture = new Gesture();
        currentGesture.gestureType = GestureType.NewGesture;
        float currentMin = Mathf.Infinity;

        foreach (var gesture in gestures)
        {
            float sumDistance = 0f;
            bool isDiscarded = false;

            for (int i = 0; i < fingerBones.Count; i++)
            {
                Vector3 currentData = skeleton.transform.InverseTransformPoint(fingerBones[i].Transform.position);
                float distance = Vector3.Distance(currentData, gesture.fingerData[i]);

                if (distance > threshold)
                {
                    isDiscarded = true;
                    break;
                }

                sumDistance += distance;
            }

            if (isDiscarded == false && sumDistance < currentMin)
            {
                currentMin = sumDistance;
                currentGesture = gesture;
            }
        }

        return currentGesture;
    }
}
