using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Scan : MonoBehaviour
{
    public static event Action OnScan;
    public static int total; 


    void Awake() => total++;
    

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


   






