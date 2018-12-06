using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clueCollect : MonoBehaviour {


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            print("Clue Collected");
            Destroy(gameObject);
        }
    }
}
