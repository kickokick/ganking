using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDoorOpening : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter2D(Collider2D coll){
        anim.Play("CoolDoorBroke");
    }
    public void OnTriggerExit(Collider coll)
    {
        anim.Play
    }
}
