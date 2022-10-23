using UnityEngine;

public class FailScoreBonus : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private string objectTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(objectTag))
        {
            Score.scoreBonus = 1;
            Score.failBonus = true;
        }
    }
}
