using UnityEngine;
using UnityEngine.Events;

public class Impact : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private string _objectTag = "FrameBlock";
    [SerializeField] private UnityEvent _onSpeedChange = new UnityEvent();

    // Private fields
    private Timer _timer;

    private void Start()
    {
        _timer = GetComponent<Timer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(_objectTag))
        {
            _onSpeedChange?.Invoke();
            _timer.StartTimer();
        }
    }
}
