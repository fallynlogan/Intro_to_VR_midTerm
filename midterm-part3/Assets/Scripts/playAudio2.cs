using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio2 : MonoBehaviour
{
    public AudioSource myAudioClip;
  

    void Start()
    {
       myAudioClip = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Point")
        {
            Debug.Log(other.tag);
            myAudioClip.Play();
        }
    }

}
