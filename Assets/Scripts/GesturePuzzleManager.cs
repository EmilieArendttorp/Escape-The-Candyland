using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GesturePuzzleManager : MonoBehaviour
{
    [SerializeField] GesturePuzzleObject coloredButtonsPuzzleObject = null;
    [SerializeField] GesturePuzzleObject objectPlacementPuzzleObject = null;
    [SerializeField] GesturePuzzleObject numberedButtonsPuzzleObject = null;

    int activeGestureBoxes = 0;

    private void Start()
    {
        if(coloredButtonsPuzzleObject && objectPlacementPuzzleObject && numberedButtonsPuzzleObject)
        {
            coloredButtonsPuzzleObject.gameObject.SetActive(false);
            objectPlacementPuzzleObject.gameObject.SetActive(false);
            numberedButtonsPuzzleObject.gameObject.SetActive(false);
        }
    }

    public void ColoredButtonsCompletion()
    {
        if (coloredButtonsPuzzleObject.isActiveAndEnabled == false)
        {
            coloredButtonsPuzzleObject.gameObject.SetActive(true);

            activeGestureBoxes++;

            if (activeGestureBoxes == 3)
            {
                FindObjectOfType<GestureDetector>().enabled = true;
            } 
        }
    }

    public void ObjectPlacementCompletion()
    {
        if (objectPlacementPuzzleObject.isActiveAndEnabled == false)
        {
            objectPlacementPuzzleObject.gameObject.SetActive(true);

            activeGestureBoxes++;

            if (activeGestureBoxes == 3)
            {
                FindObjectOfType<GestureDetector>().enabled = true;
            } 
        }
    }

    public void NumberedButtonsCompletion()
    {
        if (numberedButtonsPuzzleObject.isActiveAndEnabled == false)
        {
            numberedButtonsPuzzleObject.gameObject.SetActive(true);

            activeGestureBoxes++;

            if (activeGestureBoxes == 3)
            {
                FindObjectOfType<GestureDetector>().enabled = true;
            } 
        }
    }
}
