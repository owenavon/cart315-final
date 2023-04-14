using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerController2 : MonoBehaviour
{
    public Rigidbody rig; // A referene to our Rigidbody component
    private float downForce = 180; // Force applied when we move left or right
    private float upForce = -100;
    private float maxSpeed = 20;
    private float speed = 1;
    private float rotationSpeed = 180;

    // public float moveSpeed = 500f;

    private void Update()
    {
        float currentSpeed = rig.velocity.magnitude;

        Debug.Log(currentSpeed);

        if (currentSpeed >= maxSpeed)
        {
            rig.velocity = rig.velocity.normalized * maxSpeed;
        }


        if (currentSpeed <= 0.01)
        {
            upForce = 0;
            downForce = 0;
        }
        else
        {
            upForce = -50;
            downForce = 90;
        }
    }

    void FixedUpdate()
    {
        // Get the horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        
        // Get the Vertical input
        float verticalInput = Input.GetAxis("Vertical");

        // Add force based on our input
        rig.AddForce(Vector3.right * horizontalInput * downForce);
        
        rig.AddForce(Vector3.left * verticalInput * upForce);
        rig.AddForce(Vector3.right * verticalInput * upForce);
        rig.AddForce(Vector3.back * verticalInput * upForce);


        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);            
        }

        // Debug.Log(Vector3.right * horizontalInput * moveForce);
        // Debug.Log(Vector3.forward * verticalInput * upForce);
    }
}