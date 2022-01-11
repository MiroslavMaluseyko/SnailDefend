using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField]private float defaultMoveSpeed = 2;
    [SerializeField]private float defaultRotationSpeed = 2;

    [SerializeField] private float accelMucus = .5f;
    private Transform trans;
    
    private float _moveSpeed;
    private float _rotationSpeed;
    private int _mucusCount;
    private Rigidbody2D rb;

    public int MucusCount
    {
        get => _mucusCount;
        set => _mucusCount = value;
    }
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        _moveSpeed = defaultMoveSpeed;
        _rotationSpeed = defaultRotationSpeed;
    }

    public void Move(Vector2 movement)
    {
        if (movement == Vector2.zero) return;
        _moveSpeed = _mucusCount > 0 ? defaultMoveSpeed * accelMucus : defaultMoveSpeed;
        rb.MovePosition(rb.position + movement.normalized * _moveSpeed * Time.fixedDeltaTime);
        float targetAngle = Vector2.SignedAngle(Vector2.up, movement);
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, targetAngle,_rotationSpeed * Time.fixedDeltaTime));
    }
    
    
    

}
