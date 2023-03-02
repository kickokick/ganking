using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissappear : MonoBehaviour
{
    public Transform door;
    public BoxCollider2D place;
    private float currentPosX;
    private float currentPosY;
    private float currentPosZ;

    void Start(){
        currentPosX = door.position.x;
        currentPosY = door.position.y;
        currentPosZ = door.position.z;
    }
    public void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag == "Player"){
            door.position = new Vector3(500,500,500);
        }
    }
    public void OnTriggerExit2D(Collider2D coll){
        if (coll.gameObject.tag == "Player"){
            door.position = new Vector3(currentPosX,currentPosY,currentPosZ);
        }
    }
}
