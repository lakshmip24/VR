using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
     public float rotationSpeed = 20f;
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
            transform.position += new Vector3(0, 0.5f, 0);
        }
          
    }
}
