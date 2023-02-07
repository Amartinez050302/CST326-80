using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 velocity;
    private float radius;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
        velocity = new Vector3(speed * Random.Range(-1.0f, 1.0f), 0, speed * Random.Range(-1.0f, 1.0f));
        velocity = velocity.normalized * speed;
        radius = GetComponent<SphereCollider>().radius;
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position, radius, velocity * Time.deltaTime, out hit, velocity.magnitude * Time.deltaTime))
        {
            if (hit.collider.CompareTag("Wall"))
            {
                transform.position = hit.point + hit.normal * radius;
                velocity = Vector3.Reflect(velocity, hit.normal);
            }
            else if (hit.collider.CompareTag("Goal"))
            {
                transform.position = initialPosition;
                Debug.Log("1 Point to left Paddle");
            }
            else if (hit.collider.CompareTag("Goal1"))
            {
                transform.position = initialPosition;
                Debug.Log("1 Point to right Paddle");
            }
            else if (hit.collider.CompareTag("Paddle1"))
            {
                transform.position = hit.point + hit.normal * radius;
                velocity = Vector3.Reflect(velocity, hit.normal);
            }
            else if (hit.collider.CompareTag("Paddle2"))
            {
                transform.position = hit.point + hit.normal * radius;
                velocity = Vector3.Reflect(velocity, hit.normal);
            }
        }
        else
        {
            transform.position += velocity * Time.deltaTime;
        }
    }
}