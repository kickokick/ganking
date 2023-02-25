using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter2D(Collider2D coll){
        anim.Play("BlastDoorOpen");
    }
    public void OnTriggerExit2D(Collider2D coll){
        anim.Play("BlastDoorClose");
    }
}
