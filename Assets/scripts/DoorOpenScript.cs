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
        enter = true;
    }
    public void OnTriggerExit2D(Collider2D coll){
        enter = false;
    }
    void Update()
    {
        if (Input.GetKeyDown("e") && enter){
            anim.Play("BlastDoorOpen");
        }
        else if (Input.GetKeyDown("j") && enter){
            anim.Play("Player1Walk");
        }
    }
}
