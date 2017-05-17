using UnityEngine;

public class Data : MonoBehaviour
{
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
}