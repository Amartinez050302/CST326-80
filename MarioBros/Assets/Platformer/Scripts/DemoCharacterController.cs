using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCharacterController : MonoBehaviour
{
    public float maxSpeed = 3f;
    public float acceleration = 10f;
    public float jumpForce = 10f;
    public bool isGround;
    public float jumpBoost = 5f;
    public float speedBoost = 1.5f; 

    void Start()
    {

    }

   
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");

        
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            acceleration = 15f;
            maxSpeed = 4.5f;
        }
        else
        {
            acceleration = 10f;
            maxSpeed = 3f;
        }

        Rigidbody rbody = GetComponent<Rigidbody>();
        rbody.velocity += horizontalAxis * Vector3.right * Time.deltaTime * acceleration;

        Collider col = GetComponent<Collider>();
        float halfHeigt = col.bounds.extents.y + 0.03f;

        isGround = Physics.Raycast(transform.position, Vector3.down, halfHeigt);
        rbody.velocity = new Vector3(Mathf.Clamp(rbody.velocity.x, -maxSpeed, maxSpeed), rbody.velocity.y, rbody.velocity.z);
        if (isGround && Input.GetKeyDown(KeyCode.Space))
        {
            rbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rbody.AddForce(Vector3.up * jumpBoost, ForceMode.Force);
        }
        Color lineColor = (isGround) ? Color.green : Color.red;
        Debug.DrawLine(transform.position, transform.position + Vector3.down * halfHeigt, lineColor, 0f, false);
        float speed = rbody.velocity.magnitude;
        GetComponent<Animator>().SetFloat("Speed", speed);
    }
}
