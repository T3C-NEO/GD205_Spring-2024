using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPieces : MonoBehaviour
{
    float h;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            h = Random.Range(0.5f, 5);
            transform.position = new Vector3(transform.position.x,h,transform.position.z);
        }
    }
}
