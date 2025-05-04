using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 200f;
    public bool isJumping = false;

    private float moveInput;
    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }// Start

    
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        // เคลื่อนที่ซ้าย-ขวา
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);


        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jumpForce));

        }//Jump

    }// Update


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }//OnCollisionEnter2D

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }//OnCollisionExit2D
}
