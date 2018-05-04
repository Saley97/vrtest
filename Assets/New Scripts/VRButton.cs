using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRButton : MonoBehaviour {

    public string nextLevel;

    public void ChangeScene()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
