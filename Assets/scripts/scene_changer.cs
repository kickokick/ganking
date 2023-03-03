using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer : MonoBehaviour
{
<<<<<<< Updated upstream
    public void OnClick(string scene)
    {
        SceneManager.LoadScene(scene);
=======
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
>>>>>>> Stashed changes
    }
}
