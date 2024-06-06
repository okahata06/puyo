using UnityEngine;
using UnityEngine.UI;

public class PowerGauge : MonoBehaviour
{
    public Slider powerSlider; // �C���X�y�N�^�[�ŃX���C�_�[�����蓖�Ă�
    public float chargeSpeed = 1.0f; // �Q�[�W�������鑬�x
    public float maxChargeTime = 5.0f; // �ő�`���[�W����

    private bool isCharging = false; // �`���[�W�����ǂ����𔻒肷��t���O
    private float powerChargeTime = 0f; // ���݂̃`���[�W����

    void Update()
    {
        if (Input.GetMouseButton(0)) // ���N���b�N��������Ă����
        {
            isCharging = true;
            powerChargeTime += Time.deltaTime * chargeSpeed; // �`���[�W���Ԃ𑝂₷
            if (powerChargeTime > maxChargeTime) // �ő�`���[�W���Ԃ𒴂�����
            {
                powerChargeTime = 0f; // �`���[�W���Ԃ����Z�b�g
            }
        }
        else
        {
            isCharging = false;
        }

        // �X���C�_�[�̒l���X�V
        powerSlider.value = powerChargeTime / maxChargeTime;
    }
}
