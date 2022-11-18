using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    // Private fields
    private Score _score;

    private void Start() {
        _score = FindObjectOfType<Score>();
    }

    private void Update()
    {
        GetComponent<Text>().text = _score.ScoreNumber.ToString();
    }
}
