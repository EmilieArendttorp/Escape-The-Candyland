using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomIceHouseSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> icehousesToSpawn = null;
    [SerializeField] GameObject[] puzzleAnswerObjects = null;
    [SerializeField] int[] spawnCases = { 3, 4, 5, 6, 7, 8 };
    [SerializeField] ObjectPuzzleManager objectPuzzleManager = null;
    //[SerializeField] GameObject puzzleAnswerTest = null;

    // Start is called before the first frame update
    void Start()
    {
        if (objectPuzzleManager == null)
        {
            FindObjectOfType<ObjectPuzzleManager>();
        }

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

        SetPuzzleAnswerObject(randomIndex);

        for (int i = 0; i < numberOfIcehousesToSpawn; i++)
        {
            icehousesToSpawn[i].SetActive(true);
        }
        Debug.Log("Number of Ice houses" + numberOfIcehousesToSpawn);
    }

    void SetPuzzleAnswerObject(int index)
    {
        var puzzleAnswerObject = puzzleAnswerObjects[index];
        //puzzleAnswerTest = puzzleAnswerObject;
        //puzzleAnswerObject.transform.position = puzzleAnswerManager.transform.position + new Vector3(0f, 1f, 0f);
        //puzzleAnswerObject.GetComponent<Rigidbody>().useGravity = false;

        objectPuzzleManager.SetIceObject(puzzleAnswerObject);
    }
}
