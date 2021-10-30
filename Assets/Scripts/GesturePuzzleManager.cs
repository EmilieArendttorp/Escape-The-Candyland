using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GesturePuzzleManager : MonoBehaviour
{
    [SerializeField] GesturePuzzleObject coloredButtonsPuzzleObject = null;
    [SerializeField] GesturePuzzleObject objectPlacementPuzzleObject = null;
    [SerializeField] GesturePuzzleObject numberedButtonsPuzzleObject = null;

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
    }

    public void ObjectPlacementCompletion()
    {
        objectPlacementPuzzleObject.gameObject.SetActive(true);
    }

    public void NumberedButtonsCompletion()
    {
        numberedButtonsPuzzleObject.gameObject.SetActive(true);
    }
}
