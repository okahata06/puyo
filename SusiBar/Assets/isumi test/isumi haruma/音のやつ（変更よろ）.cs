using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
public class TEST0921 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("�}�E�X��" + gameObject.name + "�ɐG�ꂽ");
        // ��������̏���
        gameObject.transform.localScale = Vector3.one * 1.5f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("�}�E�X��" + gameObject.name + "���痣�ꂽ");
        gameObject.transform.localScale = Vector3.one;
    }
}
