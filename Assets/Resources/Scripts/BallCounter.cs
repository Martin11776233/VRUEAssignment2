using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCounter : MonoBehaviour
{
    public TextMeshProUGUI ballCountText;


    private void OnEnable()
    {
        GravityPocket.BallCountChanged += UpdateBallCountText;
    }

    private void OnDisable()
    {
        GravityPocket.BallCountChanged -= UpdateBallCountText;
    }

    private void UpdateBallCountText(int count)
    {
        ballCountText.text = "Balls in Pocket: " + count;
    }
}

