using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissappear : MonoBehaviour
{
    public Transform door;
    public BoxCollider2D place;
    public void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag == "pushbox"){
            door.position = new Vector3(500,500,500);
        }
    }
}
