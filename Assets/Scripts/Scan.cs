using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Scan : MonoBehaviour
{
    public static event Action OnScan;
    public int total; 


    void Awake() => total++;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "grocery")
        {
            if (other.gameObject.GetComponent<scancheck>().wasscanned)
            {
                print("i've already been scanned");
            }
            else
            {
                OnScan?.Invoke();
                other.gameObject.GetComponent<scancheck>().wasscanned = true;
            }
            //Debug.Log("please place item in the bagging area :)");
            
        }
    }
}


   






