using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;

public class create : EventTrigger
{

    [SerializeField, Header("�l�^�̐�")] int neta_kazu;


    

    // Start is called before the first frame update
    void Start()
    {
        //�C���X�y�N�^�Ō��߂��l�^���̔z��
        int[] neta = new int[neta_kazu];
        //�z��Ɋe�l�^�̃^�O���i�[
        for (int i=0; i<neta.Length; i++) 
        { 

        }
        //���삷��
        //GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        //foreach (GameObject obj in objs)
        //{
        //    Debug.Log(obj.gameObject.name);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�I�u�W�F�̏�Ńh���b�v
    public override void OnDrop(PointerEventData data)
    {
        Debug.Log("OnDrop called.");

    }
}
