using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    private Gamemanager gamemanager;


    private void Start()
    {
        gamemanager = FindAnyObjectByType<Gamemanager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Sandwich")
        {
            Debug.Log("Bullet has Touched");
            gamemanager.AddScore(); 
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
     
    }
}
