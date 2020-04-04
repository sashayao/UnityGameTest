using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStrawberry : MonoBehaviour
{
    public static int StrawberryCount = 0;

    public int InternalStrawberry;
    public GameObject StrawberryDisplay;
    

   
    void Update()
    {
        InternalStrawberry = StrawberryCount;
        StrawberryDisplay.GetComponent<Text>().text = "Strawberry Mochi: " + InternalStrawberry;

    }
}