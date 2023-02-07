using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoBall : MonoBehaviour
{

    Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            transform.position = initialPosition;
            Debug.Log("1 point to gryfondor");
        }
    }
}