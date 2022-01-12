using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;

    private Vector2 _direction;
    
    void Update()
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0;
        if (_direction != Vector2.zero)
        {
            animator.SetBool("Moving", true);
            controller.Move(_direction);
        }
        else
        {
            animator.SetBool("Moving", false);
        }
    }
}
