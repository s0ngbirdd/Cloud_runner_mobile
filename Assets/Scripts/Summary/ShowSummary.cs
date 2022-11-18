using UnityEngine;
using UnityEngine.UI;

public class ShowSummary : MonoBehaviour
{
    // Private fields
    private Score _score;

    private void Start() {
        _score = FindObjectOfType<Score>();
    }

    private void Update()
    {
        GetComponent<Text>().text = "Your score: " + _score.ScoreNumber.ToString();
    }
}
