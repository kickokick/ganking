using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayerTwo : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetAxis("Player 2 Vertical") > 0 || Input.GetAxis("Player 2 Vertical") < 0)
        {
            anim.Play("Player2Walk");
        }
        else if (Input.GetAxis("Player 2 Horizontal") < 0)
        {
            anim.Play("Player2WalkLeft");
        }
        else if (Input.GetAxis("Player 2 Horizontal") > 0)
        {
            anim.Play("Player2WalkRight");
        }
        else
        {
            anim.Rebind();
        }
    }
}
