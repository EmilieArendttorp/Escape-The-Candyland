using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleAnswerManager : MonoBehaviour
{
    GameObject fairyObject = null, gingerObject = null, iceObject = null;

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
            return;
        }

        if (CheckIfCorrectGingerAnswer(collision.gameObject))
        {
            //Write code here that should occur when answer is CORRECT.
            return;
        }

        if (CheckIfCorrectIceAnswer(collision.gameObject))
        {
            //Write code here that should occur when answer is CORRECT.
            Debug.Log("Correct");
            return;
        }
        Debug.Log("wrong");
        //Write code here that should occur when answer is WRONG.
    }

    bool CheckIfCorrectFairyAnswer(GameObject objectToTest)
    {
        return objectToTest == fairyObject ? true : false;        
    }

    bool CheckIfCorrectGingerAnswer(GameObject objectToTest)
    {
        return objectToTest == gingerObject ? true : false;
    }

    bool CheckIfCorrectIceAnswer(GameObject objectToTest)
    {
        return objectToTest == iceObject ? true : false;
    }
}
