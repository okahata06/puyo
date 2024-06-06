using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayImage : MonoBehaviour
{
    public Image imageComponent; // 画像を表示するImageコンポーネント
    public Sprite sanSprite; // 表示するスプライト

    void Start()
    {
        // 画像を非表示に設定
        imageComponent.enabled = false;
        // コルーチンを開始
        StartCoroutine(DisplayImageAfterDelay(3600)); // 3600秒（1時間）後に画像を表示
    }

    IEnumerator DisplayImageAfterDelay(float delay)
    {
        // 指定された秒数待機
        yield return new WaitForSeconds(delay);
        // スプライトを設定し、画像を表示
        imageComponent.sprite = sanSprite;
        imageComponent.enabled = true;
    }
}
