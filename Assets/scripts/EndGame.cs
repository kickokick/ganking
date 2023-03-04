using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI P1Count;
    public TextMeshProUGUI P2Count;
    public TextMeshProUGUI P1Text;
    public TextMeshProUGUI P2Text;
    
    void Start(){

    }
    void Update(){
        if (P1Count.text == "6"){
            P1Text.text = "The rocket is ready. Run to the rocket!";
            P2Text.text = "The rocket is ready. Run to the rocket!";
            P1Text.color = new Color(0,0,0,255);
            P2Text.color = new Color(0,0,0,255);
        }
    }
    public void OnTriggerEnter2D(Collider2D coll){
        SceneManager.LoadScene("End");
    }
}
