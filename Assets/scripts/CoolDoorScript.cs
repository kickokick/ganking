using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDoorScript : MonoBehaviour
{
    private Animator anim;
    public BoxCollider2D box;
    public PolygonCollider2D poly;
    bool enter = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter2D(Collider2D coll){
        enter = true;
    }
    void Update(){
        if (Input.GetKey(KeyCode.E) && enter){
            Debug.Log("ALLHAHH");
            anim.Play("DoorOpen");
            Destroy(box);
            Destroy(poly);
        }
    }
    public void OnTriggerExit2D(Collider2D coll){
        enter = false;
    }
}
