using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class RestartScene : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private UnityEvent _onRestart = new UnityEvent();

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        _onRestart?.Invoke();
    }
}
