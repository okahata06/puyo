using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class changeScene : MonoBehaviour
{
    public Animator animator; // �A�j���[�^�[�R���|�[�l���g�ւ̎Q��

    // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����֐�
    public void OnButtonClick()
    {
        // �R���[�`�����J�n����
        StartCoroutine(TransitionCoroutine());
    }

    // �R���[�`���֐�
    IEnumerator TransitionCoroutine()
    {
        // �A�j���[�V�������Đ�����
        animator.SetTrigger("OnClick");
        // 1�b�ԑҋ@����
        yield return new WaitForSeconds(2.0f);

        // �ړ���̃V�[�������[�h����i�V�[�����͓K�X�ύX�j
        SceneManager.LoadScene("CreateScene");
    }
}


