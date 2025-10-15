using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(1.0f, 0, 0);
        }
    }
}
