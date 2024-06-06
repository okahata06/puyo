using UnityEngine;
using UnityEngine.UI;

public class PowerGauge : MonoBehaviour
{
    public Slider powerSlider; // インスペクターでスライダーを割り当てる
    public float chargeSpeed = 1.0f; // ゲージが増える速度
    public float maxChargeTime = 5.0f; // 最大チャージ時間

    private bool isCharging = false; // チャージ中かどうかを判定するフラグ
    private float powerChargeTime = 0f; // 現在のチャージ時間

    void Update()
    {
        if (Input.GetMouseButton(0)) // 左クリックが押されている間
        {
            isCharging = true;
            powerChargeTime += Time.deltaTime * chargeSpeed; // チャージ時間を増やす
            if (powerChargeTime > maxChargeTime) // 最大チャージ時間を超えたら
            {
                powerChargeTime = 0f; // チャージ時間をリセット
            }
        }
        else
        {
            isCharging = false;
        }

        // スライダーの値を更新
        powerSlider.value = powerChargeTime / maxChargeTime;
    }
}
