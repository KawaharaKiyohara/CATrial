using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    // オブジェクト(土管)スクロールの処理
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);
        if (transform.position.x <= -15.0f)
        {
            Destroy(gameObject);
        }
    }
}
