using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioEvent : MonoBehaviour {
    public AudioClip ella;
    public AudioSource audioSource;
	// Use this for initialization

    void Play()
    {
        audioSource.PlayOneShot(ella);
    }
}
