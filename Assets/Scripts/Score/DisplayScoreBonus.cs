using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScoreBonus : MonoBehaviour
{
    // Public fields
    public bool IsIncreaseScoreBonus {get; private set;}

    // Private fields
    private Score _score;

    private void Start()
    {
        IsIncreaseScoreBonus = false;
        _score = FindObjectOfType<Score>();
    }

    private void Update()
    {
        GetComponent<Text>().text = "x" + _score.ScoreBonus.ToString();
        if (IsIncreaseScoreBonus)
        {
            ChangeTextColor();
            IsIncreaseScoreBonus = false;
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

    public void IncreaseScoreBonus(){
        IsIncreaseScoreBonus = true;
    }
}
