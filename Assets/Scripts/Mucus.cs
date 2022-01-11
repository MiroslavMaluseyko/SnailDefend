using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Mucus : MonoBehaviour
{
    [SerializeField] private float lifeTimeSeconds;
    
    void Start()
    {
        StartCoroutine(DestroyAfterTime(lifeTimeSeconds));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DestroyAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

}
