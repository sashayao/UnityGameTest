﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMochiMaker : MonoBehaviour
{
    public static int makerValue = 5;
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public GameObject bakerStat;

    public int currentStrawberry;
    public static bool turnOffButton = false;

    public static int makerCount = 0;
    public static int makerPerSecond = 0;

    public int mCount;
    public int mMaker;
    // Update is called once per frame
    void Update()
    {
        mCount = makerCount;
        mMaker = makerPerSecond;
        
        currentStrawberry = GlobalStrawberry.strawberryCount;
        bakerStat.GetComponent<Text>().text = "Makers " + makerCount + " @ " + makerPerSecond + " Per Second";
        fakeText.GetComponent<Text>().text = "Mochi maker cost " + makerValue + " Strawberries";
        realText.GetComponent<Text>().text = "Mochi maker cost " + makerValue + " Strawberries";


        if(currentStrawberry >= makerValue){
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if(turnOffButton == true){
            fakeButton.SetActive(true);
            realButton.SetActive(false);
            turnOffButton = false;
        }
        
    }
}
