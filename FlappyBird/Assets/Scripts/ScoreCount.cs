using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    private PlayerMove Player;

    void OnTriggerEnter2D(Collider2D t)
    {
        // �ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̂Ƃ�
        if (t.CompareTag("Player"))
        {
            Player = t.GetComponent<PlayerMove>();
     //       Player.HP--;   // �v���C���[�Ƀ_���[�W��^����
            Player.NowScore++;  // �v���C���[�̃X�R�A���v���X����
        }
    }
}
