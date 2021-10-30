using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleAnswerManager : MonoBehaviour
{
    GameObject fairyObject = null, gingerObject = null, iceObject = null;

    static int correctCounter = 0;

    public void SetFairyObject(GameObject answer)
    {
        fairyObject = answer;
    }

    public void SetGingerObject(GameObject answer)
    {
        gingerObject = answer;
    }

    public void SetIceObject(GameObject answer)
    {
        iceObject = answer;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (CheckIfCorrectFairyAnswer(collision.gameObject))
        {
            //Write code here that should occur when answer is CORRECT.
            //Green light
            correctCounter++;
            Debug.Log("Correct Object: " + collision.gameObject.name);

            if (correctCounter == 3)
            {
                OnPuzzleCompletion();
            }

            return;
        }

        if (CheckIfCorrectGingerAnswer(collision.gameObject))
        {
            //Write code here that should occur when answer is CORRECT.
            correctCounter++;
            Debug.Log("Correct Object: " + collision.gameObject.name);
            if (correctCounter == 3)
            {
                OnPuzzleCompletion();
            }

            return;
        }

        if (CheckIfCorrectIceAnswer(collision.gameObject))
        {
            //Write code here that should occur when answer is CORRECT.
            correctCounter++;
            Debug.Log("Correct Object: " + collision.gameObject.name);

            if (correctCounter == 3)
            {
                OnPuzzleCompletion();
            }

            return;
        }
        Debug.Log("Wrong Object");
        //Write code here that should occur when answer is WRONG.
        //Red lamp light up
    }

    void OnPuzzleCompletion()
    {
        transform.root.gameObject.SetActive(false);
        FindObjectOfType<GesturePuzzleManager>().ObjectPlacementCompletion();
    }

    bool CheckIfCorrectFairyAnswer(GameObject objectToTest)
    {
        if(objectToTest == fairyObject)
        {
            fairyObject = null;
            return true;
        }

        return false;      
    }

    bool CheckIfCorrectGingerAnswer(GameObject objectToTest)
    {
        if (objectToTest == gingerObject)
        {
            gingerObject = null;
            return true;
        }

        return false;
    }

    bool CheckIfCorrectIceAnswer(GameObject objectToTest)
    {
        if (objectToTest == iceObject)
        {
            iceObject = null;
            return true;
        }

        return false;
    }
}
