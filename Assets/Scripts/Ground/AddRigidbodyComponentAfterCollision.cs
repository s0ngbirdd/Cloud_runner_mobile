using UnityEngine;

public class AddRigidbodyComponentAfterCollision : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private string _objectTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(_objectTag))
        {
            gameObject.AddComponent<Rigidbody>();
        }
    }
}
