using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    private PlayerMove Player;

    void OnTriggerEnter2D(Collider2D t)
    {
        // 接触したオブジェクトのタグが"Player"のとき
        if (t.CompareTag("Player"))
        {
            Player = t.GetComponent<PlayerMove>();
     //       Player.HP--;   // プレイヤーにダメージを与える
            Player.NowScore++;  // プレイヤーのスコアをプラスする
        }
    }
}
