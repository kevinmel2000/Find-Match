using UnityEngine;

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
                Destroy(collision.gameObject);
            }
        }
    }
}