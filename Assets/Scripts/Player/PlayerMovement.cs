using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isGrounded;

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 15, 0);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
    }
}
