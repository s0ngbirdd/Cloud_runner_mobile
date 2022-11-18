using UnityEngine;

public class Score : MonoBehaviour
{
    // Public fields
    public int ScoreNumber {get; private set;}
    public int ScoreBonus {get; private set;}
    public bool IsFailBonus {get; private set;}

    private void Start()
    {
        ScoreNumber = 0;
        ScoreBonus = 1;
        IsFailBonus = false;
    }

    public void AddScore(){
        ScoreNumber += ScoreBonus;
    }

    public void FailBonus(){
        ScoreBonus = 1;
        IsFailBonus = true;
    }

    public void ResetScoreBonus(){
        ScoreBonus = 0;
    }

    public void ResetFailBonus(){
        IsFailBonus = false;
    }

    public void AddScoreBonus(){
        ScoreBonus++;
    }
}
