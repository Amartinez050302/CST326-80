using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float sizeMultiplier = 2f;
    public float duration = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Transform ballTransform = other.transform;
            ballTransform.localScale *= sizeMultiplier;
            Invoke("ResetBallSize", duration);
            gameObject.SetActive(false);
        }
    }

    void ResetBallSize()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball != null)
        {
            ball.transform.localScale /= sizeMultiplier;
            gameObject.SetActive(true);
        }
    }
}
