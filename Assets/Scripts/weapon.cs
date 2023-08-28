using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public float Speed;
    public float Range;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if(gameObject.transform.position.z >= Range)
        {
            Destroy(gameObject);
        }
    }

}
