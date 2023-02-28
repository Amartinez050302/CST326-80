using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            Destroy(gameObject);

            score += 100;

           
            TextMeshProUGUI scoreText = GameObject.Find("MarioScore").GetComponent<TextMeshProUGUI>();
            scoreText.SetText("Score: " + score);
        }
    }
}