using UnityEngine;
using UnityEngine.UI;

public class DestroyMatch : MonoBehaviour
{
    [SerializeField]
    public GameObject detect;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (collision.name.Contains(detect.name))
            {
                if(collision.name == Data.CarName)
                {
                    Destroy(collision.gameObject);
                    Data.Score += 5;
                }
            }
        }
    }
}