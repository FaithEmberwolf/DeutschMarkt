using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagging : MonoBehaviour
{
    public static event Action OnBagging;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<scancheck>() != null)
        {
            bool scanCheck = collision.gameObject.GetComponent<scancheck>().wasscanned;
            if (scanCheck)
            {
                OnBagging?.Invoke();
                print($"You have bagged a {collision.gameObject.name}");
            }
            else
            {
                print("you never scanned me :(");
            }
        }
    }
}