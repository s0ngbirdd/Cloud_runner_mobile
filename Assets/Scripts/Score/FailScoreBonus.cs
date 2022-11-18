using UnityEngine;

public class FailScoreBonus : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private string objectTag = "Player";

    // Private fields
    private Score _score;

    private void Start() {
        _score = FindObjectOfType<Score>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(objectTag))
        {
            _score.FailBonus();
        }
    }
}
