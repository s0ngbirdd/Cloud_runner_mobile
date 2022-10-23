using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScoreBonus : MonoBehaviour
{
    // Public fields
    public static bool increaseScoreBonus;

    private void Start()
    {
        increaseScoreBonus = false;
    }

    private void Update()
    {
        GetComponent<Text>().text = "x" + Score.scoreBonus.ToString();
        if (increaseScoreBonus)
        {
            ChangeTextColor();
            increaseScoreBonus = false;
        }
    }

    public void ChangeTextColor()
    {
        GetComponent<Text>().color = Color.yellow;
        StartCoroutine(ReturnBaseColor());
    }

    private IEnumerator ReturnBaseColor()
    {
        yield return new WaitForSeconds(1f);

        GetComponent<Text>().color = Color.white;
    }
}
