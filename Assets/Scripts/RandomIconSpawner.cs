using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomIconSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> iconToSpawn = null;
    [SerializeField] GameObject[] puzzleAnswerObjects = null;
    //[SerializeField] int[] spawnCases = { 1, 2, 3, 4, 5, 6, 7, 8 };

    public GameObject SpawnedIcon { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
         foreach (var icon in iconToSpawn)
         {
             icon.SetActive(false);
         }


        // var spawnIcons = Random.Range(0, iconToSpawn.Count);

        // SpawnRandomIcon();
        SpawnIcon();
    }

    public void SpawnIcon()
    {
        var randomIndex = Random.Range(0, iconToSpawn.Count);
        SpawnedIcon = iconToSpawn[randomIndex];                 
        
        Debug.Log(SpawnedIcon + "Name");
        SpawnedIcon.SetActive(true);
    }

    void SetPuzzleAnswerObject(int index)
    {
        var puzzleAnswerObject = puzzleAnswerObjects[index];

       // SignPuzzleManager.SetSignObject1(puzzleAnswerObject);
    }

    
}

     

     


