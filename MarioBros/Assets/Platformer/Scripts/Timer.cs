using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 100f;
    public TextMeshProUGUI countdownText;

    private void Start()
    {
        timeRemaining = 100f;
    }

    private void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            Debug.Log("You lose");
            timeRemaining = 0;
        }

        countdownText.text = string.Format("{0:F1}", timeRemaining);
    }
}