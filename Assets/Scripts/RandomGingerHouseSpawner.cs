using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGingerHouseSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> gingerhousesToSpawn = null;
    [SerializeField] GameObject[] puzzleAnswerObjects = null;
    [SerializeField] ObjectPuzzleManager objectPuzzleManager = null;
    [SerializeField] int[] spawnCases = { 3, 4, 5, 6, 7, 8 };
    //[SerializeField] GameObject puzzleAnswerTest = null;


    // Start is called before the first frame update
    void Start()
    {
        if (objectPuzzleManager == null)
        {
            FindObjectOfType<ObjectPuzzleManager>();
        }

        foreach (var gingerhouse in gingerhousesToSpawn)
        {
            gingerhouse.SetActive(false);
        }

        SpawnRandomNumberOfGingerhouses();
    }

    [ContextMenu("Spawn Gingerhouses")]
    public void SpawnRandomNumberOfGingerhouses()
    {
        var randomIndex = Random.Range(0, spawnCases.Length);
        var numberOfGingerhousesToSpawn = spawnCases[randomIndex];

        SetPuzzleAnswerObject(randomIndex);

        for (int i = 0; i < numberOfGingerhousesToSpawn; i++)
        {
            gingerhousesToSpawn[i].SetActive(true);
        }
        Debug.Log("Number of Gingerhouses" + numberOfGingerhousesToSpawn);
    }

    void SetPuzzleAnswerObject(int index)
    {
        var puzzleAnswerObject = puzzleAnswerObjects[index];
        //puzzleAnswerTest = puzzleAnswerObject;
        //puzzleAnswerObject.transform.position = puzzleAnswerManager.transform.position + new Vector3(0f, 1f, 0f);
        //puzzleAnswerObject.GetComponent<Rigidbody>().useGravity = false;

        objectPuzzleManager.SetGingerObject(puzzleAnswerObject);
    }
}

