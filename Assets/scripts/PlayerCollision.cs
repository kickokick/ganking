using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.collider == true){
            Debug.Log("Collided");
        }
        if (coll.gameObject.tag == "box"){
            Debug.Log("it works");
            SpriteRenderer bxo = coll.gameObject.GetComponent<SpriteRenderer>();
            bxo.color = Color.black;
        }
    }
    void OnCollisionExit2D(Collision2D coll){
        if (coll.gameObject.tag == "box"){
            SpriteRenderer bxo = coll.gameObject.GetComponent<SpriteRenderer>();
            bxo.color = Color.red;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
