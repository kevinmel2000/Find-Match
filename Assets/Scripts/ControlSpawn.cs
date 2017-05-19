using UnityEngine;

public class ControlSpawn : MonoBehaviour
{
    float waitShow1 = 0;
    float waitShow2 = 0;
    float waitShow3 = 0;

    float timer1 = 0;
    float timer2 = 0;
    float timer3 = 0;

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;

    public GameObject[] ob;
    float waitTime = 0;

    private void Start()
    {
        waitShow1 = Random.Range(3f, 5f);
        waitShow2 = Random.Range(1f, 4f);
        waitShow3 = Random.Range(0.5f, 5f);

        waitTime = Random.Range(4f, 4f);
    }

    private void Update()
    {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;

        if (timer1 > waitShow1)
        {
            GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spawn1.transform.position, spawn1.transform.rotation);
            waitShow1 = waitTime;
            timer1 = 0;
        }

        if (timer2 > waitShow2)
        {
            GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spawn2.transform.position, spawn2.transform.rotation);
            waitShow2 = waitTime;
            timer2 = 0;
        }

        if (timer3 > waitShow3)
        {
            GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spawn3.transform.position, spawn3.transform.rotation);
            waitShow3 = waitTime;
            timer3 = 0;
        }
    }
}