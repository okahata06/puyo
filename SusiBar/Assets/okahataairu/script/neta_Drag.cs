using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neta_Drag : MonoBehaviour
{

    bool cllick_down;

    Vector3 neta_p;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //�}�E�X�h���b�O��
    private void OnMouseDrag()
    {
        //�}�E�X�̍��W�Ɉړ�
        neta_p = Input.mousePosition;
        this.gameObject.transform.position = neta_p;


    }

}
