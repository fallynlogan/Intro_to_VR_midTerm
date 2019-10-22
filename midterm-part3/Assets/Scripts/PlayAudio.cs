using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource AudioClip;
    public float Semitones;

    void Start()
    {
        // 1.05946 ^ n changes pitch of audioclip by n semitones
        AudioClip.pitch += Mathf.Pow(1.05946f, Semitones);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if(other.tag == "Point")
        {
            AudioClip.Play();
        }
    }
}
