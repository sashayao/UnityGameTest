using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveGame : MonoBehaviour
{
    public GameObject saveButton;


    // Update is called once per frame
    public void SaveTheGame()
    {
        //saving to internal memory
        PlayerPrefs.SetInt("savedMochi", GlobalMochi.MochiCount);
        PlayerPrefs.SetInt("savedStrawberries", GlobalStrawberry.strawberryCount);
        PlayerPrefs.SetInt("savedMaker", GlobalMochiMaker.makerCount);


    }
}
