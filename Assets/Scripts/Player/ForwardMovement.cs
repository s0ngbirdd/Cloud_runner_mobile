using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    // Public fields
    public float Speed {get; private set;}

    // Private fields
    private Rigidbody _objectRigidbody;

    private void Start()
    {
        _objectRigidbody = GetComponent<Rigidbody>();
        Speed = 15f;
    }

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * Speed * Time.fixedDeltaTime;
        _objectRigidbody.MovePosition(_objectRigidbody.position + forwardMove);
    }

    public void SpeedChange(float speed){
        Speed = speed;
    }

    public void SubtractSpeed(float subtraction){
        Speed -= subtraction;
    }
}
