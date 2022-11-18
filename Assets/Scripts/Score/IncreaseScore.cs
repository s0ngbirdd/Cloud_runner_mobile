using UnityEngine;
using UnityEngine.Events;

public class IncreaseScore : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private Joystick _joystick;
    [SerializeField] private UnityEvent _onActionPerFrame = new UnityEvent();

    private void FixedUpdate()
    {
        //GetMobileIncreaseScore();
        GetDesktopIncreaseScore();
    }

    // For mobile increase score
    private void GetMobileIncreaseScore()
    {
        if (_joystick.Horizontal.Equals(0f))
        {
            _onActionPerFrame?.Invoke();
        }
    }

    // For desktop increase score (testion on desktop)
    private void GetDesktopIncreaseScore()
    {
        if (Input.GetAxis("Horizontal").Equals(0f))
        {
            _onActionPerFrame?.Invoke();
        }
    }
}
