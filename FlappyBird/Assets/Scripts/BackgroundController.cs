using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    // �w�i�X�N���[���̏���
    void Update()
    {
        transform.Translate(-0.001f, 0, 0);
        if (transform.position.x <= -18.259f)
        {
            transform.position = new Vector3(18.259f, -0.5f, 0.0f);
        }
    }
}