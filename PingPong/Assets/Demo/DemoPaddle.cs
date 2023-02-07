using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DemoPaddle : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal1 = Input.GetAxis("Horizontal1");
        float horizontal2 = Input.GetAxis("Horizontal2");

        if (gameObject.CompareTag("Paddle1"))
        {
            rb.velocity = new Vector2(horizontal1 * speed, 0);
        }
        else if (gameObject.CompareTag("Paddle2"))
        {
            rb.velocity = new Vector2(horizontal2 * speed, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"we hit {collision.gameObject.name}");
        
        // get reference to paddle collider
        BoxCollider bc = GetComponent<BoxCollider>();
        Bounds bounds = bc.bounds;
        float maxX = bounds.max.x;
        float minX = bounds.min.x;

        Debug.Log($"maxX = {maxX}, minY = {minX}");
        Debug.Log($"x pos of ball is {collision.transform.position.x}");

        Quaternion rotation = Quaternion.Euler(0f, 0f, -60f);
        Vector3 bounceDirection = rotation * Vector3.up;
        
        Rigidbody rb = collision.rigidbody;
        rb.AddForce(bounceDirection * 1000f, ForceMode.Force);
    }
}
