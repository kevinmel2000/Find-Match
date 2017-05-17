using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public Text txtScore;

    private void Start()
    {
        txtScore.text = "Kamu mendapatkan " + Data.Score.ToString() + " poin";
    }

    public void PlayGame()
    {
        Data.Score = 0;
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
}