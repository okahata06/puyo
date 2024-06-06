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
        //ネタを丸ごと代入
        neta[0] = GameObject.FindGameObjectWithTag("neta1");
        neta[1] = GameObject.FindGameObjectWithTag("neta2");
        neta[2] = GameObject.FindGameObjectWithTag("neta3");

        //初期位置の保存
        neta_pos[0] = neta[0].transform.position;
        neta_pos[1] = neta[1].transform.position;
        neta_pos[2] = neta[2].transform.position;

        //インスペクタで決めたネタ数の配列
        //int[] neta = new int[neta_kazu];


        //配列に各ネタのタグを格納
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
        //動作する



    }
    
    // Update is called once per frame
    void Update()
    {
        
        //ネタを丸ごと代入
        neta[0] = GameObject.FindGameObjectWithTag("neta1");
        neta[1] = GameObject.FindGameObjectWithTag("neta2");
        neta[2] = GameObject.FindGameObjectWithTag("neta3");

       // Debug.Log(neta[2].transform.position.x);

        if(!Input.GetMouseButton(0)&&
            neta[0].transform.position.x>=580)
        {
            //初期位置に移動
            neta[0].transform.position = neta_pos[0];
            get_neta = 0;
        }
        if (!Input.GetMouseButton(0) &&
        neta[1].transform.position.x >= 580)
        {
            //初期位置に移動
            neta[1].transform.position = neta_pos[1];
            get_neta = 1;

        }

        if (!Input.GetMouseButton(0) &&
        neta[2].transform.position.x >= 580)
        {
            //初期位置に移動
            neta[2].transform.position = neta_pos[2];
            get_neta = 2;
        }


    }
    //触れると物理演算なしで判定獲得
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

    //他スクでの参照＆変更用
    public int Get_Neta//public 戻り値 プロパティ名
    {
        get { return get_neta; }//get {return フィールド名;}
        set { get_neta= value; }//set {フィールド名 = value;}
    }



    //オブジェの上でドロップ
    //public override void OnDrop(PointerEventData data)
    //{



    //    Debug.Log("OnDrop called.");

    //}
}
