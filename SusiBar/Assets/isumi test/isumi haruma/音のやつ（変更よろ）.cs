using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
public class TEST0921 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("マウスが" + gameObject.name + "に触れた");
        // 何かしらの処理
        gameObject.transform.localScale = Vector3.one * 1.5f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("マウスが" + gameObject.name + "から離れた");
        gameObject.transform.localScale = Vector3.one;
    }
}
//いらんかったら消しといて～　　（）←マンコ