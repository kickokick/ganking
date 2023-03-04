using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class audioTrigger : MonoBehaviour
{
    public AudioSource song;

    public void OnTriggerEnter2D(Collider2D coll){
        song.Play();
    }
}
