using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private Transform objectTransform;

    // Private fields
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - objectTransform.position;
    }

    private void Update()
    {
        transform.position = objectTransform.position + _offset;
    }
}
