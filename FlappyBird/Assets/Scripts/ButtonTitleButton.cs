using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// タイトル画面のボタンが押されたときの処理
/// </summary>
public class ButtonTitleButton : MonoBehaviour
{
    //タイトルシーンのボタンかどうか
    [SerializeField] bool m_isTitleScene = false;

    public void OnClickButton()
    {
        Invoke(nameof(ChangeScene),0.5f);
    }

    void ChangeScene()
    {
        //タイトルシーン
        if (m_isTitleScene)
        {
            SceneManager.LoadScene("InGame");
            Debug.Log("インゲームシーンをロード");
        }
        //リザルトシーン
        else
        {
            SceneManager.LoadScene("TitleScene");
            Debug.Log("タイトルシーンをロード");
        }
    }
}
