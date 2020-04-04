using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//sell cookies
public class MakeStrawberry : MonoBehaviour
{
   public GameObject textBox;
   public GameObject statusBox;

   public void ClickTheButton(){
       if(GlobalMochi.MochiCount == 0){
            statusBox.GetComponent<Text>().text = "No Mochi left to make strawberry Mochi!";
            statusBox.GetComponent<Animation>().Play("StatusAni");
       }else{
            GlobalMochi.MochiCount -= 1;
            GlobalStrawberry.StrawberryCount += 1;
       }
       
   }
}
