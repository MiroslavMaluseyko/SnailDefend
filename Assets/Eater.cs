using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eater : MonoBehaviour
{
    [SerializeField] private Transform mouth;
    [SerializeField] private Collider2D mouthCollider;
    private Animator _animator;
    public Vector2 Mouth => mouth.position;

    private void Awake()
    {
        _animator = GetComponentInParent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Eatable food))
        {
            Eat(food);
        }
    }

    private void Eat(Eatable food)
    {
        _animator.SetTrigger("Eat");
        Destroy(food);
    }

}
