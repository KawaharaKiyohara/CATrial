using UnityEngine;
using TMPro;

/// <summary>
/// ���U���g��ʂŃX�R�A��\�����鏈��
/// </summary>
public class DisplayScore : MonoBehaviour
{
    //�X�R�A�e�L�X�g
    [SerializeField] TextMeshProUGUI m_scoreText = null;

    void Start()
    {
        //�l�������X�R�A��\������
        m_scoreText.text += 10;
    }
}
