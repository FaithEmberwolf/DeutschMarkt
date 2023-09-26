using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scan : MonoBehaviour
{
    public static event Action OnScan;

  
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("grocery"))
        {
            Debug.Log("please place item in the bagging area :)");
            OnScan?.Invoke();
            
        }
    }
}


   






