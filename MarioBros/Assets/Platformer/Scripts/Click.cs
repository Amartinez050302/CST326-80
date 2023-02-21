using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            // Check if the ray hit this game object
            if (hit.collider.gameObject == gameObject)
            {
                // Destroy this game object when it is clicked with the mouse
                Destroy(gameObject);
            }
        }
    }
}
