using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x+1,1,transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x,1,transform.position.z+1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x-1,1,transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x,1,transform.position.z-1);
        }
    }
}
