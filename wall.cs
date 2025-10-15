using UnityEngine;

public class wall : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; 
    }

    void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Ball") && rb.isKinematic)
    {
        rb.isKinematic = false;
        rb.AddExplosionForce(50f, collision.contacts[0].point, 5f);
    }
}
}
