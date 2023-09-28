using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanManager : MonoBehaviour
{

    public int groceryCount = 0;

    private void OnEnable() => Scan.OnScan += OnScanScan;
    private void OnDisable() => Scan.OnScan += OnScanScan;




    // Update is called once per frame
    void OnScanScan()
    {

        groceryCount++;

    }
}

