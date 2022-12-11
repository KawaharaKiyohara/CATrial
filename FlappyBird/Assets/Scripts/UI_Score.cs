using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    // TMPを扱う場合これを追加しないとダメなので注意！

public class UI_Score : MonoBehaviour
{
    private TextMeshProUGUI hp_TMP;
    private PlayerMove Player;
    void Start()
    {
        // TMPを取得
        hp_TMP = GetComponent<TextMeshProUGUI>();
        // プレイヤーの保持するスコアを取得
        // ※"Player"タグがついたオブジェクトから取得している
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }
    void Update()
    {
        // 現在スコアを表示
        hp_TMP.text = "Score:" + Player.NowScore;
    }
}
