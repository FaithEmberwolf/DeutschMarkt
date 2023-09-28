using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BaggedCount : MonoBehaviour
{
    public TextMeshProUGUI Countitems;
    private int baggeditemstotal;
    private void OnEnable() => bagging.OnBagging += Count;
    private void OnDisabe() => bagging.OnBagging -= Count;
    // Start is called before the first frame update

    public void Update()
    {
        Countitems.text = baggeditemstotal.ToString();
    }
    public void Start()
    {
        Countitems = gameObject.GetComponent<TextMeshProUGUI>();
    }
    private void Count()
    {
        baggeditemstotal++;
    }
}
