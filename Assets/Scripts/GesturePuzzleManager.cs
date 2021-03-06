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
        coloredButtonsPuzzleObject.gameObject.SetActive(true);

        activeGestureBoxes++;

        if (activeGestureBoxes == 3)
        {
            FindObjectOfType<GestureDetector>().enabled = true;
        }
    }

    public void ObjectPlacementCompletion()
    {
        objectPlacementPuzzleObject.gameObject.SetActive(true);

        activeGestureBoxes++;

        if (activeGestureBoxes == 3)
        {
            FindObjectOfType<GestureDetector>().enabled = true;
        }
    }

    public void NumberedButtonsCompletion()
    {
        numberedButtonsPuzzleObject.gameObject.SetActive(true);

        activeGestureBoxes++;

        if (activeGestureBoxes == 3)
        {
            FindObjectOfType<GestureDetector>().enabled = true;
        }
    }
}
