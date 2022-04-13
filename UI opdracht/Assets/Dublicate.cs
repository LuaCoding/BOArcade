using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dublicate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void Button()
    {
        GameObject button = Instantiate(gameObject, gameObject.transform.parent);
    }
}
