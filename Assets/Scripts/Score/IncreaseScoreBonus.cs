using UnityEngine;

public class IncreaseScoreBonus : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private string _objectTag = "Player";

    // Private fields
    private Score _score;
    private DisplayScoreBonus _displayScoreBonus;

    private void Start() {
        _score = FindObjectOfType<Score>();
        _displayScoreBonus = FindObjectOfType<DisplayScoreBonus>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(_objectTag))
        {
            if (!_score.IsFailBonus)
            {
                _score.AddScoreBonus();
                _displayScoreBonus.IncreaseScoreBonus();
            }
            _score.ResetFailBonus();
        }
    }
}
