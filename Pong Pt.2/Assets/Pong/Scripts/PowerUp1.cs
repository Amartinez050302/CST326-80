using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1 : MonoBehaviour
{
    public float speedMultiplier = 2f;
    public float duration = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody ballRigidbody = other.GetComponent<Rigidbody>();
            ballRigidbody.velocity *= speedMultiplier;
            Invoke("ResetBallSpeed", duration);
            gameObject.SetActive(false);
        }
    }

    void ResetBallSpeed()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball != null)
        {
            gameObject.SetActive(true);
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            ballRigidbody.velocity /= speedMultiplier;
        }
    }
}