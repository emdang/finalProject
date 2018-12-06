using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class captionTrigger : MonoBehaviour {
    public Animator anim;

    // Use this for initialization
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("clueTouched");
            anim.SetTrigger("captionActivated");
        }
    }
}
