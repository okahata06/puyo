using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;

public class create : MonoBehaviour
{
    static int neta_kazu = 3;

    int get_neta=100;

    GameObject[] neta =new GameObject[neta_kazu];

    Vector3[] neta_pos = new Vector3[neta_kazu];


    // Start is called before the first frame update
    void Start()
    {       
        //�l�^���ۂ��Ƒ��
        neta[0] = GameObject.FindGameObjectWithTag("neta1");
        neta[1] = GameObject.FindGameObjectWithTag("neta2");
        neta[2] = GameObject.FindGameObjectWithTag("neta3");

        //�����ʒu�̕ۑ�
        neta_pos[0] = neta[0].transform.position;
        neta_pos[1] = neta[1].transform.position;
        neta_pos[2] = neta[2].transform.position;

        //�C���X�y�N�^�Ō��߂��l�^���̔z��
        //int[] neta = new int[neta_kazu];


        //�z��Ɋe�l�^�̃^�O���i�[
        //for (int i = 0; i < neta_kazu; i++)
        //{
        //    switch (i)
        //    {
        //        case 0:
        //            GameObject[] neta1 = GameObject.FindGameObjectsWithTag("neta1");
        //            foreach (GameObject obj in neta1)
        //            {
        //                Debug.Log(obj.gameObject.name);
        //            }

        //            break;
        //        case 1:
        //            GameObject[] neta2 = GameObject.FindGameObjectsWithTag("neta2");
        //            foreach (GameObject obj in neta2)
        //            {
        //                Debug.Log(obj.gameObject.name);
        //            }

        //            break;
        //        case 2:
        //            GameObject[] neta3 = GameObject.FindGameObjectsWithTag("neta3");
        //            foreach (GameObject obj in neta3)
        //            {
        //                Debug.Log(obj.gameObject.name);
        //            }

        //            break;
        //        case 3:
        //            GameObject[] neta4 = GameObject.FindGameObjectsWithTag("neta4");
        //            foreach (GameObject obj in neta4)
        //            {
        //                Debug.Log(obj.gameObject.name);
        //            }

        //            break;

        //        default:
        //            break;
        //    }



        //}
        //���삷��



    }
    
    // Update is called once per frame
    void Update()
    {
        
        //�l�^���ۂ��Ƒ��
        neta[0] = GameObject.FindGameObjectWithTag("neta1");
        neta[1] = GameObject.FindGameObjectWithTag("neta2");
        neta[2] = GameObject.FindGameObjectWithTag("neta3");

       // Debug.Log(neta[2].transform.position.x);

        if(!Input.GetMouseButton(0)&&
            neta[0].transform.position.x>=580)
        {
            //�����ʒu�Ɉړ�
            neta[0].transform.position = neta_pos[0];
            get_neta = 0;
        }
        if (!Input.GetMouseButton(0) &&
        neta[1].transform.position.x >= 580)
        {
            //�����ʒu�Ɉړ�
            neta[1].transform.position = neta_pos[1];
            get_neta = 1;

        }

        if (!Input.GetMouseButton(0) &&
        neta[2].transform.position.x >= 580)
        {
            //�����ʒu�Ɉړ�
            neta[2].transform.position = neta_pos[2];
            get_neta = 2;
        }


    }
    //�G���ƕ������Z�Ȃ��Ŕ���l��
    public void OnTriggerEnter(Collider col)
    {
        Vector3 pos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y,-9);
        

        if (col.gameObject == neta[0])
        {
            Debug.Log("neta1_hit");
            col.gameObject.transform.position = pos;

        }
        else if (col.gameObject == neta[1])
        {
            Debug.Log("neta2_hit");
            col.gameObject.transform.position = pos;

        }
        else if (col.gameObject == neta[2])
        {
            Debug.Log("neta3_hit");
            col.gameObject.transform.position = pos;
        }


    }
    public void OnTriggerStay(Collider col)
    {
        Vector3 pos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -9);


        if (col.gameObject == neta[0])
        {
            Debug.Log("neta1_hit");
            col.gameObject.transform.position = pos;

        }
        else if (col.gameObject == neta[1])
        {
            Debug.Log("neta2_hit");
            col.gameObject.transform.position = pos;

        }
        else if (col.gameObject == neta[2])
        {
            Debug.Log("neta3_hit");
            col.gameObject.transform.position = pos;
        }
    }

    //���X�N�ł̎Q�Ɓ��ύX�p
    public int Get_Neta//public �߂�l �v���p�e�B��
    {
        get { return get_neta; }//get {return �t�B�[���h��;}
        set { get_neta= value; }//set {�t�B�[���h�� = value;}
    }



    //�I�u�W�F�̏�Ńh���b�v
    //public override void OnDrop(PointerEventData data)
    //{



    //    Debug.Log("OnDrop called.");

    //}
}