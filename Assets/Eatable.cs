using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eatable : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private ParticleSystem bloodPrefab;


    public void Death()
    {
        Instantiate(bloodPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
