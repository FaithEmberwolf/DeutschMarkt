using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scancheck : MonoBehaviour
{

    public bool wasscanned;
    public bool isbagged;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnEnable() => bagging.OnBagging += Bagme;
    public void OnDisable() => bagging.OnBagging -= Bagme;
    // Update is called once per frame
    void Update()
    {

    }
    private void Bagme()
    {

        if (wasscanned)
        {
            Destroy(gameObject);
        }
        else
        {
            
        }
        
    }
}
