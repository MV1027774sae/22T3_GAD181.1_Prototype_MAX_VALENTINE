using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgBackground : MonoBehaviour
{
    private Rigidbody2D bg;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(-2, 0, 0);
    }
}
