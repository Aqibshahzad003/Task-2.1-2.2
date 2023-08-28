using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Stampede : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float randomX;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            randomX = Random.Range(-15, 15);
            Instantiate(animalPrefabs[animalIndex], new Vector3(randomX, 0, 20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
