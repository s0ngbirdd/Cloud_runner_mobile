using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Text>().text = Score.score.ToString();
    }
}
