using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    // �I�u�W�F�N�g(�y��)�X�N���[���̏���
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);
        if (transform.position.x <= -15.0f)
        {
            Destroy(gameObject);
        }
    }
}
