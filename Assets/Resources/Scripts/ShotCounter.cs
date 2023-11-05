using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShotCounter : MonoBehaviour
{
    public TextMeshProUGUI shotText;
    private int shotCount = 0;

    public GameObject cueBall;
    public GameObject cueStick;
    private int collisionCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == cueStick)
        {
            IncrementShotCount();
            collisionCount++;
            Debug.Log("Collision Count: " + collisionCount);
        }
    }
    public void IncrementShotCount()
    {
        shotCount++;
        UpdateShotText();
    }

    private void UpdateShotText()
    {
        shotText.text = "Shots: " + shotCount;
    }
}
