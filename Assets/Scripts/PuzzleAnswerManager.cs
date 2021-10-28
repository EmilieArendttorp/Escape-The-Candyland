using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleAnswerManager : MonoBehaviour
{
    GameObject fairyObject = null, gingerObject = null, iceObject = null;

    int correctCounter = 0;


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
            Debug.Log("Correct Obejct 1");

            if (correctCounter == 3)
            {
                ThreeCorrectObjects();
            }

            return;
        }

        if (CheckIfCorrectGingerAnswer(collision.gameObject))
        {
            //Write code here that should occur when answer is CORRECT.
            correctCounter++;
            Debug.Log("Correct Object 2");
            if (correctCounter == 3)
            {
                ThreeCorrectObjects();
            }

            return;
        }

        if (CheckIfCorrectIceAnswer(collision.gameObject))
        {
            //Write code here that should occur when answer is CORRECT.
            correctCounter++;
            Debug.Log("Correct Object 3");

            if (correctCounter == 3)
            {
                ThreeCorrectObjects();
            }

            return;
        }
        Debug.Log("Wrong Object");
        //Write code here that should occur when answer is WRONG.
        //Red lamp light up
    }

    void ThreeCorrectObjects()
    {

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
