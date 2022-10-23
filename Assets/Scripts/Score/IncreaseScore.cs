using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;

    private void FixedUpdate()
    {
        GetMobileIncreaseScore();
        //GetDesktopIncreaseScore();
    }

    // For mobile increase score
    private void GetMobileIncreaseScore()
    {
        if (_joystick.Horizontal.Equals(0f))
        {
            Score.score += Score.scoreBonus;
        }
    }

    // For desktop increase score (testion on desktop)
    private void GetDesktopIncreaseScore()
    {
        if (Input.GetAxis("Horizontal").Equals(0f))
        {
            Score.score += Score.scoreBonus;
        }
    }
}
