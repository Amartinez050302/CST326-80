using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 400f;
    public TextMeshProUGUI countdownText;

    private void Start()
    {
       
        timeRemaining = 400f;
    }

    private void Update()
    {
        
        timeRemaining -= Time.deltaTime;
        countdownText.text = string.Format("{0:F1}", timeRemaining);
        
    }
}
