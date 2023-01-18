using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyhandler : MonoBehaviour
{
    public Rigidbody2D p2BodyRB;
    public Rigidbody2D p1BodyRB;
    
    public Transform p1BodyT;
    public Transform p2BodyT;

    public Transform p1Camera;
    public Transform p2Camera;

    void Start ()
    {

    }

    void Update()
    {
        p1BodyRB.velocity = new Vector3(Input.GetAxis("Player 1 Horizontal"), Input.GetAxis("Player 1 Vertical"), 0.0f);
        p2BodyRB.velocity = new Vector3(Input.GetAxis("Player 2 Horizontal"), Input.GetAxis("Player 2 Vertical"), 0.0f);

        p2Camera.position = new Vector3(p2BodyT.position.x, p2BodyT.position.y, -10.0f);
        p1Camera.position = new Vector3(p1BodyT.position.x, p1BodyT.position.y, -10.0f);
    }      
}
