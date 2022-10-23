using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private float _seconds = 1f;
    [SerializeField] private UnityEvent _onTimerEnd = new UnityEvent();

    public void StartTimer()
    {
        StartCoroutine(WaitSeconds());
    }

    private IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(_seconds);

        _onTimerEnd?.Invoke();
    }
}
