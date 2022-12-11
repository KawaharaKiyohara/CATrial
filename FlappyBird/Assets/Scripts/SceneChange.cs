using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���������ꍇ�����ǉ����Ȃ��ƃ_��

public class SceneChange : MonoBehaviour
{
    public string ResultScene;    // �J�ڐ�̃V�[����
    private PlayerMove Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }

    void Update()
    {
        // �X�y�[�X�L�[�������ꂽ��V�[����؂�ւ���
        if (Player.HP <= 0)
        {
            SceneManager.LoadScene(ResultScene);
        }
    }
}
