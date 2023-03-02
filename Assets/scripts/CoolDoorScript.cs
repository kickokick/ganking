using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDoorScript : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter2D(Collider2D coll){
        if (Input.GetKey(KeyCode.E)){
            Debug.Log("ALLHAHH");
            anim.Play("DoorOpen");
        }
    }
}
