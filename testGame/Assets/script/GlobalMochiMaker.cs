using System.Collections;
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
    public int currentStrawberry;
    public static bool turnOffButton = false;


    // Update is called once per frame
    void Update()
    {
        currentStrawberry = GlobalStrawberry.StrawberryCount;
        fakeText.GetComponent<Text>().text = "Mochi maker cost " + makerValue + " Strawberries";
        realText.GetComponent<Text>().text = "Mochi maker cost " + makerValue + " Strawberries";


        if(currentStrawberry >= makerValue){
            fakeText.SetActive(false);
            realButton.SetActive(true);
        }
        if(turnOffButton == true){
            fakeButton.SetActive(true);
            realButton.SetActive(false);
            turnOffButton = false;
        }
        
    }
}
