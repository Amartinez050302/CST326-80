using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    private int coinCount = 0;
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            Destroy(gameObject);

            score += 100;

          
            TextMeshProUGUI scoreText = GameObject.Find("MarioScore").GetComponent<TextMeshProUGUI>();
            scoreText.SetText("Score: " + score);

            coinCount++;

            
            TextMeshProUGUI coinText = GameObject.Find("CoinsScore").GetComponent<TextMeshProUGUI>();
            coinText.SetText("Coins: " + coinCount);
        }
    }

}
