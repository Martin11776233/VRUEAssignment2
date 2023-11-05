using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GravityPocket : MonoBehaviour
{ 
    public static int ballsInPocket = 0;
    public static event Action<int> BallCountChanged;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb)
        {
            // Set the balls to the "OutsideLayer" to enable normal gravity
            other.gameObject.layer = LayerMask.NameToLayer("OutsideLayer");
            rb.useGravity = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("CueBall") || other.gameObject.CompareTag("Ball"))
        {
        ballsInPocket++;
        BallCountChanged?.Invoke(ballsInPocket);
        }
    }
}
