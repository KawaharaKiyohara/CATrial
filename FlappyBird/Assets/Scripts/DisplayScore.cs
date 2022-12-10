using UnityEngine;
using TMPro;

/// <summary>
/// リザルト画面でスコアを表示する処理
/// </summary>
public class DisplayScore : MonoBehaviour
{
    //スコアテキスト
    [SerializeField] TextMeshProUGUI m_scoreText = null;

    void Start()
    {
        //獲得したスコアを表示する
        m_scoreText.text += 10;
    }
}
