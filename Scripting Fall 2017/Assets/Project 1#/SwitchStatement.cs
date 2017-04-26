using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SwitchStatement : MonoBehaviour
{
    public Input numbers;
    Text gameWords;
    //Switch for input numbers. 
    //ElseClause for to display YOU WON!!! or Game Over!!!
    //Perhaps, create ClickButton for numbers in another script. Maybe, including arrays and stuff things like that. 

    public void Switch (int numbers)
    {
        switch (numbers)
        {
            
                              
       }
    } 
    public void ElseClause ()
    {
            
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "FallingNum")
        {
            
        }
    }
}

