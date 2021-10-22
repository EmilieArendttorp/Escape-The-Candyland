using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzleManager : MonoBehaviour
{
    [System.Serializable]
    struct PuzzleCase
    {
        public Color[] buttonColors;
        public int colorAnswer;
    }

    [SerializeField] PuzzleCase[] puzzleCases = null;
    [SerializeField] PuzzleButton[] puzzleButtons = null;

    // Start is called before the first frame update
    void Start()
    {
        PickPuzzleCase();
    }

    public void PickPuzzleCase()
    {
        var randomIndex = Random.Range(0, puzzleCases.Length);
        var puzzleCase = puzzleCases[randomIndex];

        for (int i = 0; i < puzzleButtons.Length; i++)
        {
            var currentButton = puzzleButtons[i];
            currentButton.SetColor(puzzleCase.buttonColors[i]);

            currentButton.isAnswer = currentButton.GetColor() == puzzleCase.buttonColors[puzzleCase.colorAnswer] ? true : false;
        }
    }
}


