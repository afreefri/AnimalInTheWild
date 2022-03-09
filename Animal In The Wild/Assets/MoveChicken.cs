using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 goes on player 
 takes care of the movement and animating movement
 */

public class MoveChicken : MonoBehaviour
{
    public float speed = 3.0f;
    public float gravity = 20.0f;
    public float rotateSpeed = 3.0f;
    Vector3 moveDirection = Vector3.zero;

    public CharacterController controller;
    public Animator animator;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(horizontalInput, 0, verticalInput);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        //rotating
        transform.Rotate(0, horizontalInput, 0);

        //animation
        animator.SetBool("Walk", verticalInput != 0); 
    }

    /*
    public float speed = 1.0f;
    public Rigidbody body; // reference to player's rigid body
    public Animator animator;
    
    bool right = false;
    bool left = false;
    bool front = false;
    bool back = false;
    
    void Start()
    {
        front = true;
    }

    // Update is called once per frame
    void Update()
    {
        //get WASD or arrow inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // move player
        body.velocity = new Vector3(horizontalInput * speed, body.velocity.y, verticalInput * speed);


        // CHANGING WHICH WAY PLAYER FACES
        if (horizontalInput > 0.01f && right == false) // if moving right
        {
            
            if (front)
            {
                transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            }
            if (left)
            {
                transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            }
            
            right = true;
            left = false;
            front = false;
            back = false;
        }
        else if (horizontalInput < -0.01f && left == false) // if moving left
        {
            if (front)
            {
                transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            }
            if (right)
            {
                transform.Rotate(0.0f, -180.0f, 0.0f, Space.Self);
            }
            
            right = false;
            left = true;
            front = false;
            back = false;
        }
        if(verticalInput > 0.01f && front == false) // moving front
        {
            if (right)
            {
                transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            }
            if (left)
            {
                transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            }
            if (back)
            {
                transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            }
            right = false;
            left = false;
            front = true;
            back = false;
        }
        else if(verticalInput < -0.01f && back == false) //moving back
        {
            if (right)
            {
                transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            }
            if (left)
            {
                transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            }
            if (front)
            {
                transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            }
            right = false;
            left = false;
            front = false;
            back = true;
        }

        animator.SetBool("Walk", horizontalInput != 0 || verticalInput != 0); // player move animation when wasd or arrow keys pressed
    }
    */
}
