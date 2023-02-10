using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI playerText;
    public SpriteRenderer player;
    public Canvas canvi; 

    void Start()
    {
        player = GetComponent<SpriteRenderer>();
    }

    public void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag == "box"){
            player.color = Color.red;
            playerText.color = new Color(0,0,0,255);

        }
    }
    void OnTriggerExit2D(Collider2D coll){
        if (coll.gameObject.tag == "box"){
            player.color = Color.white;
            playerText.color = new Color(0,0,0,0);
        }
    }
}