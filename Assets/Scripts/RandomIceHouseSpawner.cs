using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomIceHouseSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> icehousesToSpawn = null;
    [SerializeField] GameObject[] puzzleAnswerObjects = null;
    [SerializeField] int[] spawnCases = { 3, 4, 5, 6, 7, 8 };

    PuzzleAnswerManager puzzleAnswerManager = null;

    // Start is called before the first frame update
    void Start()
    {
        puzzleAnswerManager = FindObjectOfType<PuzzleAnswerManager>();

        foreach (var icehouse in icehousesToSpawn)
        {
            icehouse.SetActive(false);
        }

        SpawnRandomNumberOfIcehouses();
    }

    [ContextMenu("Spawn Icehouses")]
    public void SpawnRandomNumberOfIcehouses()
    {
        var randomIndex = Random.Range(0, spawnCases.Length);
        var numberOfIcehousesToSpawn = spawnCases[randomIndex];

        // SetPuzzleAnswerObject(randomIndex);

        for (int i = 0; i < numberOfIcehousesToSpawn; i++)
        {
            icehousesToSpawn[i].SetActive(true);
        }
        Debug.Log(numberOfIcehousesToSpawn);
    }

    void SetPuzzleAnswerObject(int index)
    {
        var puzzleAnswerObject = puzzleAnswerObjects[index];

        puzzleAnswerManager.SetIceObject(puzzleAnswerObject);
    }
}
