using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    private Animator playerShoot;
    public Transform shootingOffset;
    public float moveSpeed = 5f;
    AudioSource audioSource; 

    public AudioClip shootingSound; 

    private void Start()
    {
        playerShoot = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerShoot.SetTrigger("ShootG");
            GameObject shot = Instantiate(bullet, shootingOffset.position, Quaternion.identity);
            Debug.Log("Bang!");

            Destroy(shot, 3f);

            audioSource.PlayOneShot(shootingSound);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * horizontalInput * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
          
            Destroy(gameObject, 0.5f);
        }
    }
}