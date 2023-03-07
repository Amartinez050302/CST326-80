using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f;
    public float distanceToWall = 1f;

    private bool hitWall = false;
    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = transform.position;
    }

    private void Update()
    {
        if (!hitWall)
        {
            targetPosition += Vector3.right * speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            hitWall = true;
            targetPosition += Vector3.down * distanceToWall;
            speed = -speed;
        }
    }
}