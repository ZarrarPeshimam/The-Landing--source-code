using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject prefab;    
    

    private void Start()
    {
        SpawnPrefab();
    }

    private void SpawnPrefab()
    {
       
        Instantiate(prefab);

        float spawnInterval = Random.Range(0.2f, 1.5f);

        Invoke(nameof(SpawnPrefab), spawnInterval);
    }
}