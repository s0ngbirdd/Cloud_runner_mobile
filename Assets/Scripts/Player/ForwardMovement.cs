using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    // Public fields
    public static float speed;

    // Private fields
    private Rigidbody _objectRigidbody;

    private void Start()
    {
        _objectRigidbody = GetComponent<Rigidbody>();
        speed = 15f;
    }

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        _objectRigidbody.MovePosition(_objectRigidbody.position + forwardMove);
    }
}
