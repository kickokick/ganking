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
    public TextMeshProUGUI P1Ready;
    public TextMeshProUGUI P2Ready;
    
    public BoxCollider2D Player1;
    public BoxCollider2D Player2;

    
    private bool ready;
    private bool P1Enter;
    private bool P2Enter;
    
    void Start(){
        ready = false;
    }
    void Update(){
        if (P1Count.text == "6" || P2Count.text == "6"){
            P1Ready.text = "Active";
            P2Ready.text = "Active";
            P1Ready.color = new Color(0,255,55,255);
            P2Ready.color = new Color(0,255,55,255);
            ready = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D coll){
        if (ready == false){
            if (coll.gameObject.CompareTag("Player1")){
                P1Text.text = "The rocket is not ready";
                P1Text.color = new Color(255,255,255,255);
                P1Enter = false;
            }
            else if (coll.gameObject.tag == "Player2"){
                P2Text.text = "The rocket is not ready";
                P2Text.color = new Color(255,255,255,255);
                P2Enter = false;
            }
        }
        else if (ready == true){
            if (coll.gameObject.CompareTag("Player1")){
                P1Text.text = "Wait for white to catch up!";
                P1Text.color = new Color(255,255,255,255);
                P1Enter = true;
            }
            else if (coll.gameObject.tag == "Player2"){
                P2Text.text = "Wait for black to catch up!";
                P2Text.color = new Color(255,255,255,255);
                P2Enter = true;
            }
            if (P1Enter && P2Enter){
                SceneManager.LoadScene("End");
            }
        }
    }
    public void OnTriggerStay2D(Collider2D coll)
    {
        if (ready == false){
            P1Text.text = "The rocket is not ready.";
            P2Text.text = "The rocket is not ready.";
            P1Text.color = new Color(255,255,255,255);
            P2Text.color = new Color(255,255,255,255);
        }
        else if (ready == true){
            if (coll.gameObject.tag == "Player1"){
                P1Text.text = "Wait for white to catch up!";
                P1Text.color = new Color(255,255,255,255);
                P1Enter = true;

            }
            else if (coll.gameObject.tag == "Player2"){
                P2Text.text = "Wait for black to catch up!";
                P2Text.color = new Color(255,255,255,255);
                P2Enter = true;
            }
            if (P1Enter && P2Enter){
                SceneManager.LoadScene("End");
            }
        }
    }
    public void OnTriggerExit2D(Collider2D coll){
        P1Enter = false;
        P2Enter = false;
        P1Text.color = new Color(0,0,0,0);
        P2Text.color = new Color(0,0,0,0);
    }
}
