using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textTrigger : MonoBehaviour
{
    public TextMeshProUGUI PlayerText1;
    public TextMeshProUGUI PlayerText2;
    
    public BoxCollider2D Player1;
    public BoxCollider2D Player2;
    
    public BoxCollider2D Trigger;
    public string text;
    private int time1 = 0;
    private int time2 = 0;
    

    public void OnTriggerEnter2D(Collider2D coll){
        if (time1 == 0)
        {
            if (coll.gameObject.tag == "Player1"){
                PlayerText1.text = text;
                PlayerText1.color = new Color(255,255,255,255);
                time1 = 1;
            }
        }
        if (time2 == 0)
        {
            if (coll.gameObject.tag == "Player2"){
                PlayerText2.text = text;
                PlayerText2.color = new Color(255,255,255,255);
                time2 = 1;
            }
        }
    }
    public void OnTriggerExit2D(Collider2D coll){
        PlayerText1.color = new Color(255,255,255,0);
        PlayerText2.color = new Color(255,255,255,0);
    }

}
