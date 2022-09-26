using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1TilemapMovement : MonoBehaviour
{
    private Rigidbody2D tm;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(-6, 0, 0);
    }
}
