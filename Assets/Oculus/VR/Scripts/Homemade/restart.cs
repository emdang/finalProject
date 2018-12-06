using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {
    public void ChangeScene()
    {
        //Changes to GameScene
        Debug.Log("Change Scene");
        SceneManager.LoadScene("Intro");
    }
}
