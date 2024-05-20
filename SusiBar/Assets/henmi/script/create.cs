using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;

public class create : EventTrigger
{

    [SerializeField, Header("ネタの数")] int neta_kazu;


    

    // Start is called before the first frame update
    void Start()
    {
        //インスペクタで決めたネタ数の配列
        int[] neta = new int[neta_kazu];
        //配列に各ネタのタグを格納
        for (int i=0; i<neta.Length; i++) 
        { 

        }
        //動作する
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

    //オブジェの上でドロップ
    public override void OnDrop(PointerEventData data)
    {
        Debug.Log("OnDrop called.");

    }
}
