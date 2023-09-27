using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groceryCount : MonoBehaviour
{

    TMPro.TMP_Text text;
    public int count;
    public bool wasscanned;
    
    //public GameObject grocery; 
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();

    }

    private void Start() => UpdateCount(); 
        
    private void OnEnable() => Scan.OnScan += OnScanScan;
    private void OnDisable() => Scan.OnScan -= OnScanScan; 
   

    void OnScanScan()
    {
        if (wasscanned)
        {
            print("i've already been scanned");
        }
        else
        {
            //updates count by 1
            count++;
            UpdateCount();
            wasscanned = true;
        }

    }

    private void UpdateCount()
    {
        //tells UI to show how many scanned out of how many needs to be scanned 
        text.text = $"{count} / 6";

    }

}