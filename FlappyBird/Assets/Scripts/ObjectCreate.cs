using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreate : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject collision;
    private float time;
    private float vecX;
    private float vecY;

    void Start()
    {
        time = Random.Range(1.0f, 3.0f);
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0.0f)
        {
            vecX = Random.Range(2.0f, 4.0f);
            vecY = Random.Range(1.0f, 6.0f);
            time = vecX;
            Instantiate(ball, new Vector3(15, -vecY, -1), Quaternion.identity);
            Instantiate(collision, new Vector3(15, -vecY, 0), Quaternion.identity);
        }
    }
}
