using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevHacks : MonoBehaviour
{
    public void CompleteColoredButtons()
    {
        FindObjectOfType<GesturePuzzleManager>().ColoredButtonsCompletion();
    }

    public void CompleteObjectPuzzle()
    {
        FindObjectOfType<GesturePuzzleManager>().ObjectPlacementCompletion();
    }

    public void CompleteSignPuzzle()
    {
        FindObjectOfType<GesturePuzzleManager>().NumberedButtonsCompletion();
    }
}
