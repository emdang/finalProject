using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorUnlock : MonoBehaviour {
    public GameObject door;
    public BoxCollider colli;
    public BoxCollider clockCollider;
    public Collider paper;
    public MeshRenderer clue;
    public MeshRenderer clue2;
    // Use this for initialization

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "lock")
        {
            print("Clue Collected");
            door.GetComponent<MeshCollider>().enabled = true;
            colli.enabled = false;
            clockCollider.enabled = false;
            paper.enabled = true;
            clue.enabled = true;
            clue2.enabled = true;
            Destroy(gameObject);
        }
    }
}
