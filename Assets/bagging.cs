using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagging : MonoBehaviour
{



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
        if (collision.gameObject.tag == "grocery")
        {
            print($"You have bagged a {collision.gameObject.name}");
        }
    }
}
