using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
     public float rotationSpeed = 50f;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Renderer objectRenderer = GetComponent<Renderer>();
             if (objectRenderer != null)
            {
                objectRenderer.material.color = Color.green;
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.P))
        {
            transform.position += new Vector3(1.0f, 0, 0);
        }
          
    }
}
