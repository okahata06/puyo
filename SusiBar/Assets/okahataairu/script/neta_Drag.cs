using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class neta_Drag : MonoBehaviour
{
    [SerializeField,Header("ドラッグ中の座標")] int z_pos;


    bool cllick_down;
    //座標移動用
    Vector3 neta_p;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Screen.width);
        //Debug.Log(Screen.height);
    }

    //ドラッグ中
    private void OnMouseDrag()
    {
        //画面サイズの取得
        float w = Screen.width;
        float h = Screen.height;
        
        //画面サイズによって移動量を変更。これが限界
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
        //カーソルの位置にネタを移動
        this.gameObject.transform.position = neta_p;

    }


}
