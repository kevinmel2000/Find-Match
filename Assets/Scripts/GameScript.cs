using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
}