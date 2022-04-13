using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class MakeOrbitSun : MonoBehaviour
{
    public GameObject sun;
    public Vector3 velocity= new Vector3(1, 2, 0);
    public Vector3 acceleration ;
    public float n = 0f;
    public float distance= 0f;

 

    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("Sun");
    }

 

    // Update is called once per frame
    void Update()
    {
        acceleration =  sun.transform.position - transform.position;
        distance = acceleration.magnitude;

 

        acceleration = 3f * acceleration * 1f/acceleration.magnitude;

 

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

 

        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(velocity.y,velocity.x)*Mathf.Rad2Deg);
        
        if(distance < 200f)
        {
            Vector3 normal = acceleration * 1 / acceleration.magnitude;
            normal = normal * Vector3.Dot(normal, velocity);
            Vector3 perpendicular = velocity - normal;
            normal = -normal;
            velocity = normal + perpendicular;

 

            transform.position += 10* velocity * Time.deltaTime;
        }

 

        
    }
}