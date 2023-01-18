using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI playerText;
    public void OnCollisionEnter2D(Collision2D coll){
        if (coll.collider == true){
            Debug.Log("Collided");
        }
        if (coll.gameObject.tag == "box"){
            Debug.Log("it works");
            SpriteRenderer bxo = coll.gameObject.GetComponent<SpriteRenderer>();
            bxo.color = Color.black;
            playerText.color = new Color(0,0,0,255);
        }
    }
    void OnCollisionExit2D(Collision2D coll){
        if (coll.gameObject.tag == "box"){
            SpriteRenderer bxo = coll.gameObject.GetComponent<SpriteRenderer>();
            bxo.color = Color.red;
            playerText.color = new Color(0,0,0,0);
        }
    }
    
}
