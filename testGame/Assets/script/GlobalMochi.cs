using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMochi : MonoBehaviour
{
    public static int MochiCount = 0;
    public GameObject MochiDisplay;
    public int InternalMochi;
    

   
    void Update()
    {
        InternalMochi = MochiCount;
        MochiDisplay.GetComponent<Text>().text = "Mochi: " + InternalMochi;

    }
}
