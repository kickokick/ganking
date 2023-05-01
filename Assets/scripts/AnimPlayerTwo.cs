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
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            anim.Play("Player2Walk");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            anim.Play("Player2Walk");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            anim.Play("Player2Idle");
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.Play("Player2Idle");
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                return;
            }
        }
    }
}
