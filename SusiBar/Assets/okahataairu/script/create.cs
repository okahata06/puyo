using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;

public class create : MonoBehaviour
{

    int neta_kazu = 3;




    // Start is called before the first frame update
    void Start()
    {
        //�C���X�y�N�^�Ō��߂��l�^���̔z��
        //int[] neta = new int[neta_kazu];


        //�z��Ɋe�l�^�̃^�O���i�[
        for (int i = 0; i < neta_kazu; i++)
        {
            switch (i)
            {
                case 0:
                    GameObject[] neta1 = GameObject.FindGameObjectsWithTag("neta1");
                    foreach (GameObject obj in neta1)
                    {
                        Debug.Log(obj.gameObject.name);
                    }

                    break;
                case 1:
                    GameObject[] neta2 = GameObject.FindGameObjectsWithTag("neta2");
                    foreach (GameObject obj in neta2)
                    {
                        Debug.Log(obj.gameObject.name);
                    }

                    break;
                case 2:
                    GameObject[] neta3 = GameObject.FindGameObjectsWithTag("neta3");
                    foreach (GameObject obj in neta3)
                    {
                        Debug.Log(obj.gameObject.name);
                    }

                    break;
                case 3:
                    GameObject[] neta4 = GameObject.FindGameObjectsWithTag("neta4");
                    foreach (GameObject obj in neta4)
                    {
                        Debug.Log(obj.gameObject.name);
                    }

                    break;

                default:
                    break;
            }



        }
        //���삷��
    }
    
    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger.hit");

    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision.hit");
    }
    //�I�u�W�F�̏�Ńh���b�v
    //public override void OnDrop(PointerEventData data)
    //{



    //    Debug.Log("OnDrop called.");

    //}
}
