using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterstitialAdManager : MonoBehaviour
{
    public static InterstitialAdManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }

 
}
