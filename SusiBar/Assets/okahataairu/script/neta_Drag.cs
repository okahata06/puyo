using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class neta_Drag : MonoBehaviour
{
    [SerializeField,Header("�h���b�O���̍��W")] int z_pos;


    bool cllick_down;
    //���W�ړ��p
    Vector3 neta_p;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        neta_p = this.gameObject.transform.position;
        if (neta_p.z < -5)
            neta_p.z += 0.1f;
        this.gameObject.transform.position = neta_p;
        //Debug.Log(Screen.width);
        //Debug.Log(Screen.height);
    }




    //�h���b�O��
    private void OnMouseDrag()
    {
        //��ʃT�C�Y�̎擾
        float w = Screen.width;
        float h = Screen.height;
        
        //��ʃT�C�Y�ɂ���Ĉړ��ʂ�ύX�B���ꂪ���E
        if(w>= 1920 || h>=900)
        {
            neta_p = new Vector3(Input.mousePosition.x * 0.3f + 30, Input.mousePosition.y * 0.3f + 20, z_pos);
        }
        else if(w>=1000||h>=500)
        {
            neta_p = new Vector3(Input.mousePosition.x * 0.46f + 35, Input.mousePosition.y * 0.47f + 20, z_pos);
        }
        else
        {
            neta_p = new Vector3(Input.mousePosition.x * 1f + 35, Input.mousePosition.y * 1f + 25, z_pos);
        }
        //�J�[�\���̈ʒu�Ƀl�^���ړ�
        this.gameObject.transform.position = neta_p;

    }


}
