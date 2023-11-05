using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private Rigidbody rb;
 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the ball is on the "OutsideLayer"
        if (gameObject.layer == LayerMask.NameToLayer("OutsideLayer"))
        {
        
            rb.useGravity = true;
        }
    }
}
