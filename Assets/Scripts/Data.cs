using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    // tampilkan score ke scene gameplay
    public Text txtScore;
    private void Update()
    {
        txtScore.text = score.ToString();
    }

    // tempat penyimpanan data score
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

    private static string carName = "";
    public static string CarName
    {
        get
        {
            return carName;
        }

        set
        {
            carName = value;
        }
    }
}