using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public ParticleSystem movementSparks;
    public ParticleSystem jumpSparks;
    public Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;

    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float jumpVelocity = 15f;

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            float jumpVelocity = 19f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            CreateJumpSparks();
        }
        if (IsGrounded())
        {
            CreateMovementSparks();
        }
    }
    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 0.15f, layerMask);
        return raycastHit2d.collider != null;
    }

    public void CreateMovementSparks()
    {
        movementSparks.Play();
    }

    public void CreateJumpSparks()
    {
        jumpSparks.Play();
    }
}
