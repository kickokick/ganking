using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyhandler : MonoBehaviour
{
    public Rigidbody2D bodyRB;
    public Transform bodyT;
    public Transform camera;

    float horizontal;
    float vertical;

    void Start ()
    {
        bodyRB = GetComponent<Rigidbody2D>();
        bodyT = GetComponent<Transform>();
    }

    void Update()
    {
        bodyRB.velocity = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0.0f);
        camera.position = new Vector3(bodyT.position.x, bodyT.position.y, -10.0f);
    }
}