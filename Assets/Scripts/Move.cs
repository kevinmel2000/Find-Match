using UnityEngine;

public class Move : MonoBehaviour
{
    float range = 0f;
    float count = 0f;
    float speed = 0.6f;
    public Sprite[] img;

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = img[Random.Range(0, img.Length)];
        range = Random.Range(40f, 300f);
    }

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * 1f, speed * Time.deltaTime * move_steer(), 0);
        if(transform.position.x > 8f)
        {
            GameObject.Destroy(gameObject);
        }
    }

    float move_steer()
    {
        float value = 0f;
        count += 1f;

        if (count <= range) value = 1f;
        if (count > range) value = -1f;
        if (count > (range * 2) - 1) count = 0f;
        return value;
    }
}