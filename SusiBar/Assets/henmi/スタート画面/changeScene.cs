using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class changeScene : MonoBehaviour
{
    public Animator animator; // アニメーターコンポーネントへの参照

    // ボタンがクリックされたときに呼び出される関数
    public void OnButtonClick()
    {
        // コルーチンを開始する
        StartCoroutine(TransitionCoroutine());
    }

    // コルーチン関数
    IEnumerator TransitionCoroutine()
    {
        // アニメーションを再生する
        animator.SetTrigger("OnClick");
        // 1秒間待機する
        yield return new WaitForSeconds(2.0f);

        // 移動先のシーンをロードする（シーン名は適宜変更）
        SceneManager.LoadScene("スタート画面");
    }
}


