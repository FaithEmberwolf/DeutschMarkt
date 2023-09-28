using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnBad : MonoBehaviour
{
    public int totalinbag;
    public void OnEnable() => bagging.OnBagging += BagCheck;
    public void OnDisable() => bagging.OnBagging -= BagCheck;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       


        if (totalinbag > 0)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void BagCheck()
    {
        totalinbag++;
    }


}
