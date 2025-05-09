using UnityEngine;

public class Ball : MonoBehaviour
{
    public float bounceForce = 500f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;

        rb.AddForce(normal * bounceForce, ForceMode.Impulse);
    }
}