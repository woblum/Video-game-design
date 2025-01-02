using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 25.0f;

    Rigidbody rb;
    Transform t;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    
    void Update()
    {
      
        if (Input.GetKey(KeyCode.W))
            rb.velocity += this.transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.D))
            rb.velocity += this.transform.right * speed * Time.deltaTime; 
        else if (Input.GetKey(KeyCode.A))
            rb.velocity -= this.transform.right * speed * Time.deltaTime;

        
    }
}