using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayerOne : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetAxis("Player 1 Vertical") > 0 || Input.GetAxis("Player 1 Vertical") < 0)
        {
            anim.Play("Player1Walk");
        }
        else if (Input.GetAxis("Player 1 Horizontal") < 0)
        {
            anim.Play("Player1WalkLeft");
        }
        else if (Input.GetAxis("Player 1 Horizontal") > 0)
        {
            anim.Play("Player1WalkRight");
        }
        else
        {
            anim.Rebind();
        }
    }
}
