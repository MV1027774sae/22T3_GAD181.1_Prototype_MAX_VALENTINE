using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMidground : MonoBehaviour
{
    private Rigidbody2D bg;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(-3.5f, 0, 0);
    }
}
