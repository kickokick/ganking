using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    private Animator anim;
    public BoxCollider2D p1hit;
    public BoxCollider2D p2hit;
    
    bool enter;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter2D(Collider2D coll){
        if (Input.GetKeyDown("e")){
         anim.Play("BlastDoorOpen");   
        }
        else if (Input.GetKeyDown(KeyCode.RightShift))
        {
            anim.Play("BlastDoorOpen"); 
        }
    }
    public void OnTriggerStay2D(Collider2D coll){
        if (Input.GetKeyDown("e")){
         anim.Play("BlastDoorOpen");   
        }
        else if (Input.GetKeyDown(KeyCode.RightShift))
        {
            anim.Play("BlastDoorOpen"); 
        }
    }
}
