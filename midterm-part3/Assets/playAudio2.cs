using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSource : MonoBehaviour
{
    public AudioSource AudioClip;
  

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Point")
        {
            Debug.Log(other.tag);
            AudioClip.Play();
        }
    }
}
