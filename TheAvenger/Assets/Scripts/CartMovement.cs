using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public float RotateSpeed = 30f;
   
    // Use this for initialization
    void Start () {
        
            rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("i"))
        rb.AddForce(transform.forward * thrust);
      
        if (Input.GetKey("j"))
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        else if (Input.GetKey("l"))
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
    }
    
   
}

    


