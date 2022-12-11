using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �^�C�g����ʂ̃{�^���������ꂽ�Ƃ��̏���
/// </summary>
public class ButtonTitleButton : MonoBehaviour
{
    //�^�C�g���V�[���̃{�^�����ǂ���
    [SerializeField] bool m_isTitleScene = false;

    public void OnClickButton()
    {
        Invoke(nameof(ChangeScene),0.5f);
    }

    void ChangeScene()
    {
        //�^�C�g���V�[��
        if (m_isTitleScene)
        {
            SceneManager.LoadScene("InGame");
            Debug.Log("�C���Q�[���V�[�������[�h");
        }
        //���U���g�V�[��
        else
        {
            SceneManager.LoadScene("TitleScene");
            Debug.Log("�^�C�g���V�[�������[�h");
        }
    }
}
