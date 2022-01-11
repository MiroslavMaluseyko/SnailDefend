using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MucusGenerator : MonoBehaviour
{
    [SerializeField] private GameObject prefMucus;
    [SerializeField] private float delayInSeconds;
    [SerializeField] private Transform MucusPoint;
    
    private Coroutine _gen;
    void Start()
    {
        _gen = StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(delayInSeconds);
            Instantiate(prefMucus, MucusPoint.position, MucusPoint.rotation);
        }
    }

    private void OnDestroy()
    {
        StopCoroutine(_gen);
    }
}
