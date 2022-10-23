using UnityEngine;

public class Score : MonoBehaviour
{
    // Public fields
    public static int score;
    public static int scoreBonus;
    public static bool failBonus;

    private void Start()
    {
        score = 0;
        scoreBonus = 1;
        failBonus = false;
    }
}
