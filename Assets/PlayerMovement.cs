using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float movementSpeed = 500f;

    
    void FixedUpdate()
    {
        rb.useGravity = false;
        rb.AddForce(0, 0, movementSpeed * Time.deltaTime);
    }
}
