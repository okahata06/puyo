using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neta_Drag : MonoBehaviour
{
    [SerializeField,Header("ドラッグ中の座標")] int z_pos;


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

    //マウスドラッグ中
    private void OnMouseDrag()
    {
        //マウスの座標に移動
        neta_p =new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_pos);
        this.gameObject.transform.position = neta_p;


    }

}
