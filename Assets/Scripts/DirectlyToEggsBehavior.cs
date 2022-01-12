using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectlyToEggsBehavior : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private Animator _animator;
    private Vector2 _eggsPos;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _eggsPos = GameObject.FindWithTag("Eggs").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 dir = _eggsPos -_rb.position;
        if(dir.sqrMagnitude > 2)
            controller.Move(dir);
    }
}
