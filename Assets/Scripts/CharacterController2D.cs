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
    
    private float _moveSpeed;
    private float _rotationSpeed;
    private int _mucusCount;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _moveSpeed = defaultMoveSpeed;
        _rotationSpeed = defaultRotationSpeed;
    }

    public void Move(Vector2 movement)
    {
        movement.Normalize();
        _moveSpeed = _mucusCount > 0 ? defaultMoveSpeed * accelMucus : defaultMoveSpeed;
        _rb.MovePosition(_rb.position + movement * _moveSpeed * Time.fixedDeltaTime);
        float targetAngle = Vector2.SignedAngle(Vector2.up, movement);
        _rb.MoveRotation(Mathf.LerpAngle(_rb.rotation, targetAngle,_rotationSpeed * Time.fixedDeltaTime));
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Mucus")) _mucusCount++;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Mucus")) _mucusCount--;
        _mucusCount = _mucusCount < 0 ? 0 : _mucusCount;
    }
}
