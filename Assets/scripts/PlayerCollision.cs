using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI playerText;
    public SpriteRenderer bxo;

    void Start()
    {
        bxo = GetComponent<SpriteRenderer>();
    }

    public void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == "box"){
            bxo.color = Color.red;
            playerText.color = new Color(0,0,0,255);
        }
    }
    void OnCollisionExit2D(Collision2D coll){
        if (coll.gameObject.tag == "box"){
            bxo.color = Color.white;
            playerText.color = new Color(0,0,0,0);
        }
    }
}
