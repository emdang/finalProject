using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablePin : MonoBehaviour {
    public GameObject gO;
    public Collider Co;
    private void OnTriggerEnter(Collider col)
    {
        if (col==Co)
        {
            print("Clue Collected");
            gO.GetComponent<BoxCollider>().enabled = true;
            //Destroy(gameObject);
        }
    }
}
