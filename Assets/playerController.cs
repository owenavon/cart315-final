using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerController : MonoBehaviour
{
    public Rigidbody rig; // A referene to our Rigidbody component
    public float moveForce; // Force applied when we move left or right
    // public float moveSpeed = 500f;

    void FixedUpdate()
    {
        // Get the horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        
        // Get the Vertical input
        float verticalInput = Input.GetAxis("Vertical");

        //if (Input.GetKey("down"))
        //{
            //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        //}

        // Add force based on our input
        rig.AddForce(Vector3.right * horizontalInput * moveForce);
        rig.AddForce(Vector3.forward * verticalInput * moveForce);
    }
}