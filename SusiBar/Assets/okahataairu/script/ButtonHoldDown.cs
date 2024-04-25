using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoldDown : MonoBehaviour
{
    private bool buttonDownFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (buttonDownFlag)
        {
            // �{�^�����������ςȂ��̏�Ԃ̎��ɂ̂݁uHold�v��\������B
            Debug.Log("Hold");
        }
    }
    // �{�^�����������Ƃ��̏���
    public void OnButtonDown()
    {
        Debug.Log("Down");
        buttonDownFlag = true;
    }
    // �{�^���𗣂����Ƃ��̏���
    public void OnButtonUp()
    {
        Debug.Log("Up");
        buttonDownFlag = false;
    }
}
