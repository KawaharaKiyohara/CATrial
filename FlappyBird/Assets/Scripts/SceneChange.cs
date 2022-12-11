using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーンを扱う場合これを追加しないとダメ

public class SceneChange : MonoBehaviour
{
    public string ResultScene;    // 遷移先のシーン名
    private PlayerMove Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }

    void Update()
    {
        // スペースキーが押されたらシーンを切り替える
        if (Player.HP <= 0)
        {
            SceneManager.LoadScene(ResultScene);
        }
    }
}
