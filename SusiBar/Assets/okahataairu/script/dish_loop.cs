using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dish_loop : MonoBehaviour
{
    [SerializeField]
    private Vector3 spawn;
    [SerializeField]
    private int despawn;
    [SerializeField]
    private float speed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.gameObject.transform.position;

        position.x += speed;

        if(position.x>=despawn)
        {
            position = spawn;
        }

        transform.position = position;
        
    }
}
