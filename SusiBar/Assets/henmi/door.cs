using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    AudioSource _audiosource;
    public AudioClip sound;

    void Start()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _audiosource.PlayOneShot(sound);
        }
    }
}