using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayImage : MonoBehaviour
{
    public Image imageComponent; // �摜��\������Image�R���|�[�l���g
    public Sprite sanSprite; // �\������X�v���C�g

    void Start()
    {
        // �摜���\���ɐݒ�
        imageComponent.enabled = false;
        // �R���[�`�����J�n
        StartCoroutine(DisplayImageAfterDelay(3600)); // 3600�b�i1���ԁj��ɉ摜��\��
    }

    IEnumerator DisplayImageAfterDelay(float delay)
    {
        // �w�肳�ꂽ�b���ҋ@
        yield return new WaitForSeconds(delay);
        // �X�v���C�g��ݒ肵�A�摜��\��
        imageComponent.sprite = sanSprite;
        imageComponent.enabled = true;
    }
}
