using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public Text txtScore;

    private static int score = 0;

    public static int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    private void Update()
    {
        txtScore.text = score.ToString();
    }
}