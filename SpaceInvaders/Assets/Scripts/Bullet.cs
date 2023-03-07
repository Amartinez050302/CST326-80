using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
private Rigidbody2D myRigidbody2D;
public float speed = 5;

   
private List<Enemy> enemies = new List<Enemy>();

void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        FindEnemies();
        Fire();
    }

    private void FindEnemies()
    {
        Enemy[] enemiesArray = FindObjectsOfType<Enemy>();
        foreach (Enemy enemy in enemiesArray)
        {
            enemies.Add(enemy);
        }
    }

    private void Fire()
    {
        myRigidbody2D.velocity = Vector2.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

          
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.speed *= 2f;
                }
            }

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddToScore(10);
            }
        }
        else if (collision.gameObject.CompareTag("enemy1"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

           
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.speed *= 2f;
                }
            }

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddToScore(20);
            }
        }
        else if (collision.gameObject.CompareTag("enemy2"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

           
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.speed *= 2f;
                }
            }

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddToScore(30);
            }
        }
        else if (collision.gameObject.CompareTag("enemy3"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.speed *= 2f;
                }
            }

            int randomScore = Random.Range(10, 51);
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddToScore(randomScore);
            }
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("barrier"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}