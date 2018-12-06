using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockClick : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
            gameObject.GetComponent<AudioSource>().Play();
    }
}
