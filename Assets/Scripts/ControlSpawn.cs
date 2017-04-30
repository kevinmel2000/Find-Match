using UnityEngine;

public class ControlSpawn : MonoBehaviour
{
    float waitShow = 0;
    float timer = 0;

    public GameObject spawn;
    public GameObject[] ob;

    private void Start()
    {
        waitShow = Random.Range(0f, 3f);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > waitShow)
        {
            GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spawn.transform.position, spawn.transform.rotation);
            waitShow = Random.Range(4f, 6f);
            timer = 0;
        }
    }
}