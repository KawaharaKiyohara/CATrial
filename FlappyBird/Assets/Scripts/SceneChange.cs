using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーンを扱う場合これを追加しないとダメ

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
        // スペースキーが押されたらシーンを切り替える
        if (Player.HP <= 0 && change ==0)
        {
            change = 1;
            SceneManager.LoadScene("ResultScene", LoadSceneMode.Additive);

        }
    }
}
