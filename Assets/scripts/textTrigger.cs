using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textTrigger : MonoBehaviour
{
    public TextMeshProUGUI PlayerText;
    public BoxCollider2D Player;
    public BoxCollider2D Trigger;
    public string text;

    public void OnTriggerEnter2D(Collider2D coll){
            PlayerText.text = text;
            PlayerText.color = new Color(0,0,0,255);
    }
    public void OnTriggerExit2D(Collider2D coll){
        PlayerText.color = new Color(0,0,0,0);
    }

}
