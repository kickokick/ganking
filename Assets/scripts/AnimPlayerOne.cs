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
        if (Input.GetKeyDown("w"))
        {
            anim.Play("Player1Walk");
        }
        if (Input.GetKeyDown("s"))
        {
            anim.Play("Player1Walk");
        }
        if (Input.GetKeyDown("d"))
        {
            anim.Play("Player1WalkRight");
            if (Input.GetKeyUp("d"))
            {
                return;
            }
        }
        if (Input.GetKeyDown("a"))
        {
            anim.Play("Player1WalkLeft");
            if (Input.GetKeyUp("a"))
            {
                return;
            }
        }

    }
}
