using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GesturePuzzleObject : MonoBehaviour
{
    //[SerializeField] GestureType gestureToPerform = GestureType.NewGesture;
    [SerializeField] TextMeshPro text = null;
    [SerializeField] int lockCombinationNumber = 0;

    Gesture gesture;
    RandomIconSpawner randomIconSpawner = null;
    GesturePuzzleIcon gesturePuzzleIcon = null;


    private void Start()
    {
        randomIconSpawner = GetComponent<RandomIconSpawner>();

        if(text == null)
        {
            text = GetComponentInChildren<TextMeshPro>();
        }

        text.text = lockCombinationNumber.ToString();
        text.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        GestureDetector.NewGestureRecognizedEvent += OnGestureRecognized;
    }

    private void OnDisable()
    {
        GestureDetector.NewGestureRecognizedEvent -= OnGestureRecognized;
    }

    public void OnGestureRecognized(Gesture recognizedGesture)
    {
        if(gesturePuzzleIcon == null)
        {
            gesturePuzzleIcon = randomIconSpawner.SpawnedIcon.GetComponent<GesturePuzzleIcon>();
            gesture = new Gesture { fingerData = null, gestureType = gesturePuzzleIcon.gestureToPerform };
            print("Icon was null");
        }

        print("Gesture after" + gesture.gestureType.ToString());
        print("recognizxedgesture" + recognizedGesture.gestureType.ToString());

        if(recognizedGesture.gestureType == gesture.gestureType)
        {
            randomIconSpawner.SpawnedIcon.GetComponent<SpriteRenderer>().enabled = false;
            text.gameObject.SetActive(true);
        }
    }

    [ContextMenu("Test")]
    public void Test()
    {
        //var gesture = new Gesture { fingerData = null, gestureType = randomIconSpawner.SpawnedIcon.GetComponent<GesturePuzzleIcon>().gestureToPerform };
        var gesture = new Gesture { fingerData = null, gestureType = GestureType.NewGesture };
        OnGestureRecognized(gesture);
    }
}
