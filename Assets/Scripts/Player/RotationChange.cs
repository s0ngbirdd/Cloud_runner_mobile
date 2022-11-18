using UnityEngine;

public class RotationChange : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private float _sensitivityHor = 9.0f;
    [SerializeField] private Joystick _joystick;

    private void Update()
    {
        if (!FindObjectOfType<FinishLevel>().IsFinish)
        {
            //GetMobileInput();
            GetDesktopInput();
        }
    }

    // For mobile inputs
    private void GetMobileInput()
    {
        transform.Rotate(0, _joystick.Horizontal * _sensitivityHor, 0);
    }

    // For desktop inputs (testion on desktop)
    private void GetDesktopInput()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * _sensitivityHor, 0);
    }
}
