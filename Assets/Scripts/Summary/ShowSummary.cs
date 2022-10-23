using UnityEngine;
using UnityEngine.UI;

public class ShowSummary : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Text>().text = "Your score: " + Score.score.ToString();
    }
}
