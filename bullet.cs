using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0.0f, 1.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0.0f, -1.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0.0f, 0.7f, 0.0f, Space.Self);
        }
    }
    onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "balloon")
        {
            Destroy(gameObject);
            score.score+=1;
        }
    }

}
