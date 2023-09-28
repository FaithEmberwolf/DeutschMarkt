using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    private void Update()
    {

        //tells UI to show how many scanned out of how many needs to be scanned 
        text.text = $"{count} / 6";

    }

    private void Scanitem()
    {
        count++;
    }

    private void OnEnable() => Scan.OnScan += Scanitem;
    private void OnDisable() => Scan.OnScan -= Scanitem;



}