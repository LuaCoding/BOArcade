using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(-0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= new Vector3(0, 0, -0.01f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, 0.01f);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 5, 0);
        }

        Debug.Log("position = " + transform.position + " object = " + gameObject.name);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
    }
}

