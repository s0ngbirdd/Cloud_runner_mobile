using UnityEngine;

public class LockRotationAngle : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _slerpSpeed = 0.01f;

    private void Update()
    {
        // Slerp to nearest 90 angle, if no horizontal changes
        GetMobileLockRotation();
        //GetDesktopLockRotation();
    }


    // For mobile lock rotation
    private void GetMobileLockRotation()
    {
        if (_joystick.Horizontal.Equals(0f))
        {
            Vector3 vec = transform.eulerAngles;
            vec.y = Mathf.Round(vec.y / 90) * 90;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(vec), _slerpSpeed);
        }
    }

    // For desktop lock rotation (testion on desktop)
    private void GetDesktopLockRotation()
    {
        if (Input.GetAxis("Horizontal").Equals(0f))
        {
            Vector3 vec = transform.eulerAngles;
            vec.y = Mathf.Round(vec.y / 90) * 90;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(vec), _slerpSpeed);
        }
    }
}
