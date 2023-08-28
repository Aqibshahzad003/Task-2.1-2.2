using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if(transform.position.z <= -10)
        {
            Destroy(gameObject);
        }
    }
}
