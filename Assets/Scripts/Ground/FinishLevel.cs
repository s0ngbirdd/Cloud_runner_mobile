using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    // Public fields
    public static bool isFinish;

    // Serialize fields
    [SerializeField] private string _objectTag = "Player";

    private void Start()
    {
        isFinish = false;
    }

    // Drop all fields values
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals(_objectTag))
        {
            if (ForwardMovement.speed > 0)
            {
                ForwardMovement.speed -= 0.1f;
            }
            Score.scoreBonus = 0;
            isFinish = true;
        }
    }
}
