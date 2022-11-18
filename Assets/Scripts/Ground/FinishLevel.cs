using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    // Public fields
    public bool IsFinish {get; private set;}

    // Serialize fields
    [SerializeField] private string _objectTag = "Player";
    [SerializeField] private float _speedSubtraction = 0.1f;

    // Private fields
    private ForwardMovement _forwardMovement;
    private Score _score;

    private void Start()
    {
        IsFinish = false;
        _forwardMovement = FindObjectOfType<ForwardMovement>();
        _score = FindObjectOfType<Score>();
    }

    // Drop all fields values
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals(_objectTag))
        {
            if (_forwardMovement.Speed > 0)
            {
                _forwardMovement.SubtractSpeed(_speedSubtraction);
            }
            _score.ResetScoreBonus();
            IsFinish = true;
        }
    }

    public void IsFinishReset(){
        IsFinish = false;
    }
}
