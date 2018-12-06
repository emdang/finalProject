using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textChange : MonoBehaviour {
    public Text myText;
    public string newText;


    // Update is called once per frame
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            myText.text = newText;
        }
    }
}
