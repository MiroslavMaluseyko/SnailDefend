using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isPaused;

    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
