using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueStickCollision : MonoBehaviour
{
    
    public ShotCounter shotCounter;

    private bool collisionInProgress = false;
    private float collisionCooldown = 1.0f; 


    private void Update()
    {
        if (collisionInProgress)
        {
            collisionCooldown -= Time.deltaTime;
            if (collisionCooldown <= 0)
            {
                collisionInProgress = false;
                collisionCooldown = 1.0f;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collisionInProgress && collision.gameObject.CompareTag("CueBall"))
        {
            shotCounter.IncrementShotCount();
            collisionInProgress = true;
        }
    }
}
