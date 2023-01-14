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

    float p1x;
    float p1y;
    float p2x;
    float p2y;

    void Start ()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            p1y = 1.0f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            p1y = -1.0f;
        }
        else
        {
            p1y = 0.0f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            p1x = 1.0f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            p1x = -1.0f;
        }
        else
        {
            p1x = 0.0f;
        }

        p1BodyRB.velocity = new Vector3(p1x, p1y, 0.0f);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            p2y = 1.0f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            p2y = -1.0f;
        }
        else
        {
            p2y = 0.0f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            p2x = -1.0f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            p2x = 1.0f;
        }
        else
        {
            p2x = 0.0f;
        }

        p2BodyRB.velocity = new Vector3(p2x, p2y, 0.0f);

        p2Camera.position = new Vector3(p2BodyT.position.x, p2BodyT.position.y, -10.0f);
        p1Camera.position = new Vector3(p1BodyT.position.x, p1BodyT.position.y, -10.0f);
    }      
}
