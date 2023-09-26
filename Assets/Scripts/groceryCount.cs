using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groceryCount : MonoBehaviour
{

    TMPro.TMP_Text text;
    int count;
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
        //updates count by 1
        count++;
        UpdateCount(); 
    }

    private void UpdateCount()
    {
        //tells UI to show how many scanned out of how many needs to be scanned 
        text.text = $"{count} / 6";
    }
}