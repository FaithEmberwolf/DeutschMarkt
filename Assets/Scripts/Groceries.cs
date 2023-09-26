using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Groceries : MonoBehaviour
{
    public GameObject[] groceries;  
    // Start is called before the first frame update
    void Start()
    {
        int grocery = Random.Range(0, groceries.Length);
        groceries[grocery].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
