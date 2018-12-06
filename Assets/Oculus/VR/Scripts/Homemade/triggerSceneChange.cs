using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerSceneChange : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Fail")
        {
            print("Clue Collected");
            SceneManager.LoadScene("Fail");
        }
        else if (col.gameObject.tag == "Success")
            SceneManager.LoadScene("Success");
        else if (col.gameObject.tag == "Main")
        {
            print("Touched");
            SceneManager.LoadScene("SampleScene");
        }
            
    }
}

