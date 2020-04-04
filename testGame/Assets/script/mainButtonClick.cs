using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mainButtonClick : MonoBehaviour
{
   public GameObject textBox;

   public void ClickTheButton(){
       GlobalMochi.MochiCount += 1;
   }

}
