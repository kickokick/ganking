using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer : MonoBehaviour
{
    public void OnClick(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
