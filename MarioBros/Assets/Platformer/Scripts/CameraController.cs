using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   
    public float speed = 10f;

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float horizontalMovement = horizontalInput * speed * Time.deltaTime;

        transform.Translate(horizontalMovement, 0f, 0f);
    }
}
