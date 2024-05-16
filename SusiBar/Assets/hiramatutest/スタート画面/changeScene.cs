using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public Button myButton;
    public string �X�^�[�g���;
    public float waitTime = 2f;

    void Start()
    {
        myButton.onClick.AddListener(OnMyButtonClick);
    }
    
    void OnMyButtonClick()
    {
        StartCoroutine(WaitAndLoadScene());
    }
    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene("�X�^�[�g���");
    }
}
