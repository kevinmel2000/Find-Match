using UnityEngine;
using UnityEngine.UI;

public class DestroyMatch : MonoBehaviour
{
    [SerializeField]
    private Text txtScore;
    public GameObject detect;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (collision.name.Contains(detect.name))
            {
                Destroy(collision.gameObject);
                Data.Score += 10;
                txtScore.text = Data.Score.ToString();
            }
        }
    }
}