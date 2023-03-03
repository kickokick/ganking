using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textTrigger : MonoBehaviour
{
    public TextMeshProUGUI P1Text;
    public TextMeshProUGUI P2Text;
    public string message;

    public void OnTriggerEnter2D(Collider2D coll){
        P1Text.text = message;
        P1Text.color = new Color(0,0,0,255);
    }
    public void OnTriggerExit2D(Collider2D coll){
        P1Text.color = new Color(0,0,0,0);
    }

}
