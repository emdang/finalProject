using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickedScript : MonoBehaviour {
    public bool picked;
    private void Start()
    {
        picked = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            picked = true;
    }
}
