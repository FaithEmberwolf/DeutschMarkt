using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultDisplay : MonoBehaviour
{

    public TMPro.TMP_Text text;
    int groceryCount; 

    // Start is called before the first frame update
    void Start()
    {
        GameObject scanManagerObj = GameObject.Find("ScanManager");

        if (scanManagerObj != null)
        {
            ScanManager scanManager = scanManagerObj.GetComponent<ScanManager>();

            text.text = $"{scanManager.groceryCount} / 6";

        }
        else
        {
            Debug.LogError("ScanManager object not found");
        }
    }
}


    
