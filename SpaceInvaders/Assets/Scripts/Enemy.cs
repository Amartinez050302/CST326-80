using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1f;
    public float moveDistance = 1f;

    private bool movingRight = true;

    private void Update()
    {
        
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("hit");
            movingRight = !movingRight;
            transform.position += Vector3.down * moveDistance;
        }
    }

    private void Move()
    {
       
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
       
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}