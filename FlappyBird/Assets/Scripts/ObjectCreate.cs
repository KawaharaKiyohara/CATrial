using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreate : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject ballup;
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
        //ƒ‰ƒ“ƒ_ƒ€‚Å“yŠÇ‚ğ¶¬
        time -= Time.deltaTime;
        if (time <= 0.0f)
        {
            vecX = Random.Range(1.5f, 3.0f);
            vecY = Random.Range(2.0f, 6.0f);
            time = vecX;
            Instantiate(ball, new Vector3(15, -vecY, -1), Quaternion.identity);
            Instantiate(ballup, new Vector3(15, -vecY+10.0f, -1), Quaternion.Euler(180, 0, 0));
            Instantiate(collision, new Vector3(15, -vecY, 0), Quaternion.identity);
        }
    }
}
