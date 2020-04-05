using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStrawberry : MonoBehaviour
{
    public static int strawberryCount = 0;

    public int internalStrawberry;
    public GameObject strawberryDisplay;
    

   
    void Update()
    {
        internalStrawberry = strawberryCount;
        strawberryDisplay.GetComponent<Text>().text = "Strawberry Mochi: " + internalStrawberry;

    }
}