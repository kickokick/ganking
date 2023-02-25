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
        if (Input.GetKeyDown("w")){
            anim.Play("Player1Walk");
        }
        else if (Input.GetKeyDown("s")){
            anim.Play("Player1Walk");
        }
        else if (Input.GetKeyUp("w")){
            anim.Play("Player1Idle");
        }
        else if (Input.GetKeyUp("s")){
            anim.Play("Player1Idle");
        }
    }
}
