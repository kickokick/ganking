using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDetect : MonoBehaviour
{
    public string scene;
    public Animator anim;
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
        anim.Play("RollingText");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && scene != "null"){
            SceneManager.LoadScene(scene);
        }
    }
}
