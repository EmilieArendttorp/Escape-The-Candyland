using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFairySpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> fairiesToSpawn = null;
    [SerializeField] GameObject[] puzzleAnswerObjects = null;
    [SerializeField] int[] spawnCases = { 3, 4, 5, 6 };

    PuzzleAnswerManager puzzleAnswerManager = null;

    // Start is called before the first frame update
    void Start()
    {
        puzzleAnswerManager = FindObjectOfType<PuzzleAnswerManager>();

        foreach (var fairy in fairiesToSpawn)
        {
            fairy.SetActive(false);
        }

        SpawnRandomNumberOfFairies();
    }

    [ContextMenu("Spawn Fairies")]
    public void SpawnRandomNumberOfFairies()
    {
        var randomIndex = Random.Range(0, spawnCases.Length);
        var numberOfFairiesToSpawn = spawnCases[randomIndex];

       // SetPuzzleAnswerObject(randomIndex);

        for (int i = 0; i < numberOfFairiesToSpawn; i++)
        {
            fairiesToSpawn[i].SetActive(true);
        }

        Debug.Log("Number of Fairies" + numberOfFairiesToSpawn);
    }

    void SetPuzzleAnswerObject(int index)
    {
        var puzzleAnswerObject = puzzleAnswerObjects[index];

        puzzleAnswerManager.SetFairyObject(puzzleAnswerObject);
        Debug.Log("Fairy answer " + puzzleAnswerObject);
    }
}
