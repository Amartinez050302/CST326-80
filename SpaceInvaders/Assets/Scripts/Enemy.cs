using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed = 1f;
    public float moveDistance = 1f;
    AudioSource audioSource;
    public AudioClip deathSound;

    private bool movingRight = true;

    private void Update()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            movingRight = !movingRight;
            transform.position += Vector3.down * moveDistance;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            AudioSource.PlayClipAtPoint(deathSound, transform.position);
            SceneManager.LoadScene("Credits");
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