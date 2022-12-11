using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���������ꍇ�����ǉ����Ȃ��ƃ_��

public class SceneChange : MonoBehaviour
{
    private PlayerMove Player;
    private int change = 0;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }

    void Update()
    {
        // �X�y�[�X�L�[�������ꂽ��V�[����؂�ւ���
        if (Player.HP <= 0 && change ==0)
        {
            change = 1;
            SceneManager.LoadScene("ResultScene", LoadSceneMode.Additive);

        }
    }
}
