using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCueBallPosition : MonoBehaviour
{
    public GameObject cueBall;
    public GameObject fixedBall; // Reference to the fixed ball by name or tag.

    void Start()
    {
        // Set the initial random position for the cue ball around the fixed ball.
        SetCueBallPositionAroundFixedBall();
    }

    public void SetCueBallPositionAroundFixedBall()
{
    if (cueBall != null && fixedBall != null)
    {
        // Calculate a random offset for the x and z axes.
        float xOffset = Random.Range(-0.2f, 0.2f);
        float zOffset = Random.Range(-0.2f, 0.2f);
        
        Vector3 fixedBallPosition = fixedBall.transform.position;

        // Set the cue ball's position with the y-axis unchanged.
        Vector3 randomPosition = new Vector3(fixedBallPosition.x + xOffset, fixedBallPosition.y, fixedBallPosition.z + zOffset);

        // Set the cue ball's position to the random position.
        cueBall.transform.position = randomPosition;
    }
}
}
