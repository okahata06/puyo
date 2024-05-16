using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public RectTransform ship;
    public RectTransform UMA;
    private int counter = 0;
    private float move = 0.1f;

    // Start is called before the first frame update
    //void Start()
    //{
    //    
    //}

    // Update is called once per frame
    void Update()
    {
        ship.position += new Vector3(0, move, 0);
        counter++;
        if(counter==100)
        {
            counter = 0;
            move *= -1;
        }
        
    }
}
