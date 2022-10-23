using UnityEngine;

public class IncreaseScoreBonus : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private string _objectTag = "Player";

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(_objectTag))
        {
            if (!Score.failBonus)
            {
                Score.scoreBonus += 1;
                DisplayScoreBonus.increaseScoreBonus = true;
            }
            Score.failBonus = false;
        }
    }
}
