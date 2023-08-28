using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float Xrange;
    public float spawnPosZ;

    public float Spawninterval;

    public GameObject[] animals; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2f, Spawninterval);
    }

    void SpawnAnimal()
    {

        Vector3 SpawnPos = new Vector3(Random.Range(-Xrange, Xrange), 0, spawnPosZ);

        
            int animalindex =Random.Range(0, animals.Length);

            Instantiate(animals[animalindex], SpawnPos, animals[animalindex].transform.rotation);
        
    }
}
