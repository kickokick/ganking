using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureScript : MonoBehaviour
{
    public BoxCollider2D pressure;
    public Transform wall;
    // Start is called before the first frame update
    private float xPoi;
    private float yPoi;
    private float zPoi;
    void Start()
    {
        xPoi = wall.position.x;
        yPoi = wall.position.y;
        zPoi = wall.position.z;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall.position = new Vector3(500, 500, 500);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        wall.position = new Vector3(xPoi, yPoi, zPoi);
    }
}
