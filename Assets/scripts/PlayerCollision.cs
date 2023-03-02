using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UIElements;


public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI playerText;
    public SpriteRenderer player;
    public Canvas canvi; 

    void Start()
    {
        player = GetComponent<SpriteRenderer>();
    }

    /*public void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag == "shop"){
            playerText.color = new Color(0,0,0,255);
            playerText.text = "Press \"E\" or \"Shift\" to interact";
            if (Input.GetKey(KeyCode.E)){
                Debug.Log("First one works");
                playerText.text = "Hello! This is very cool p1 \n Press \"E\" to continue";
                Debug.Log("SEecond loine");
                if (Input.GetKeyDown("e")){
                playerText.text = "Hello! \n Press \"E\" to continue";
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightShift)){
                playerText.text = "Hello! This is very cool P2 \n Press \"Shift\" to continue";
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll){
        if (coll.gameObject.tag == "shop"){
            playerText.color = new Color(0,0,0,0);
        }
    }*/
}