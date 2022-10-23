using UnityEngine;

public class Impact : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private string _objectTag = "FrameBlock";
    [SerializeField] private float _speedChange = 5f;

    // Private fields
    private Timer _timer;
    private ChangeSpeed _changeSpeed;

    private void Start()
    {
        _timer = FindObjectOfType<Timer>();
        _changeSpeed = FindObjectOfType<ChangeSpeed>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(_objectTag))
        {
            _changeSpeed.SpeedChange(_speedChange);
            _timer.StartTimer();
        }
    }
}
