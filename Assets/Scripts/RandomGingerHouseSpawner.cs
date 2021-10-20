using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGingerHouseSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> gingerhousesToSpawn = null;
    [SerializeField] GameObject[] puzzleAnswerObjects = null;
    [SerializeField] int[] spawnCases = { 3, 4, 5, 6, 7, 8 };

    PuzzleAnswerManager puzzleAnswerManager = null;

    // Start is called before the first frame update
    void Start()
    {
        puzzleAnswerManager = FindObjectOfType<PuzzleAnswerManager>();

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

        // SetPuzzleAnswerObject(randomIndex);

        for (int i = 0; i < numberOfGingerhousesToSpawn; i++)
        {
            gingerhousesToSpawn[i].SetActive(true);
        }
        Debug.Log(numberOfGingerhousesToSpawn);
    }

    void SetPuzzleAnswerObject(int index)
    {
        var puzzleAnswerObject = puzzleAnswerObjects[index];

        puzzleAnswerManager.SetGingerObject(puzzleAnswerObject);
    }
}

