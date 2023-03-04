using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using System;

public class Demer : MonoBehaviour
{
    public BoxCollider2D trigger;
    public TextMeshProUGUI P1Count;
    public TextMeshProUGUI P2Count;
    public Transform demercan;
    public int xPos;
    public int yPos;

    private int counter;
    private bool enter;
    private void Start()
    {
        counter = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enter = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        enter = false;
    }
        void Update()
        {
            if (counter < 1)
            {
                if (enter && Input.GetKeyDown(KeyCode.E))
                {
                    counter = Int32.Parse(P1Count.text) + 1;
                    P1Count.text = counter.ToString();
                    P2Count.text = counter.ToString();
                    demercan.position = new Vector3(xPos, yPos);
                }
                else if (enter && Input.GetKeyDown(KeyCode.RightShift))
                {
                    counter = Int32.Parse(P1Count.text) + 1;
                    P1Count.text = counter.ToString();
                    P2Count.text = counter.ToString();
                    demercan.position = new Vector3(xPos, yPos);
                }
            }
        }
}
