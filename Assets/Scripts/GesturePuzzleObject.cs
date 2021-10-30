using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GesturePuzzleObject : MonoBehaviour
{
    [SerializeField] GestureType gestureToPerform = GestureType.NewGesture;
    [SerializeField] TextMeshPro text = null;
    [SerializeField] SpriteRenderer spriteRenderer = null;
    [SerializeField] int lockCombinationNumber = 0;

    Gesture gesture;

    private void Start()
    {
        gesture = new Gesture { fingerData = null, gestureType = gestureToPerform };

        if(text == null)
        {
            text = GetComponentInChildren<TextMeshPro>();
        }

        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
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
        if(recognizedGesture.gestureType == gesture.gestureType)
        {
            spriteRenderer.enabled = false;
            text.gameObject.SetActive(true);
        }
    }

    [ContextMenu("Test")]
    public void Test()
    {
        var gesture = new Gesture();
        gesture.fingerData = null;
        gesture.gestureType = GestureType.NewGesture;
        OnGestureRecognized(gesture);
    }
}
