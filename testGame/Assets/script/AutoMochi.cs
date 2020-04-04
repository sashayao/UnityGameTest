using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMochi : MonoBehaviour
{

    public bool CreatingMochi = false;
    public static int MochiIncrease = 1;
    
    public int internalIncrease;


    // Update is called once per frame
    void Update()
    {
        internalIncrease = MochiIncrease;
        if (CreatingMochi == false){
            CreatingMochi = true;
            StartCoroutine(CreateTheMochi());
        }
        
    }

    IEnumerator CreateTheMochi()
    {
        GlobalMochi.MochiCount += internalIncrease;
        yield return new WaitForSeconds(1);
        CreatingMochi = false;
    }


}
