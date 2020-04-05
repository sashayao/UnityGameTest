using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoMochi;

    public void StartAutoMochi(){
        AutoMochi.SetActive(true);
        GlobalStrawberry.strawberryCount -= GlobalMochiMaker.makerValue;
        GlobalMochiMaker.makerValue *= 2;
        GlobalMochiMaker.turnOffButton = true;
        GlobalMochiMaker.makerCount += 1;
        GlobalMochiMaker.makerPerSecond += 1;

    }
}
