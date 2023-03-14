using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 5f;
    public float fireInterval = 2f;
    public Transform firePoint;
    public GameObject player;

    private float timeUntilNextFire = 0f;

    private void Update()
    {
        if (Time.time >= timeUntilNextFire)
        {
            Fire();
            timeUntilNextFire = Time.time + fireInterval;
        }
    }

    private void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Vector2 direction = (player.transform.position - transform.position).normalized;
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}
