using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ileri;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() 
    {
        if(Input.GetAxis("Horizontal") != 0){
            transform.Translate(Vector3.forward * Time.deltaTime * ileri);
        }
    }

    void FixedUpdate()
    {
        // if (Input.GetAxis("Horizontal") != 0)
        // {
        //     rb.AddForce(Vector3.right * Time.fixedDeltaTime * ileri);
        // }
    }
}
