using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 forward = transform.forward;
            forward.y = 0;
            forward.Normalize();
            rb.velocity = forward * speed;
        }
    }
}
