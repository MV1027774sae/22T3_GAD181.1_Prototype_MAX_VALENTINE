using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    private Rigidbody2D tm;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(-8, 0, 0);
    }
}
