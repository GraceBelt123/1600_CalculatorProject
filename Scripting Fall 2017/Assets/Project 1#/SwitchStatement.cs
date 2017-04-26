using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SwitchStatement : MonoBehaviour
{
    public Input numbers;
    Text gameWords;
	public Text gameover;
	Text won;
    //Switch for input numbers. 
    //ElseClause for to display YOU WON!!! or Game Over!!!
    //Perhaps, create ClickButton for numbers in another script. Maybe, including arrays and stuff things like that. 
	void Start(){
		gameover.enabled = false;
	}
//    public void Switch (int numbers)
//    {
//        switch (numbers)
//        {
//				case 1:				
//            
//                              
//       }
//    } 
//    public void ElseClause ()
//    {
//            
//    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "FallingNum")
        {
			print ("Collided");
			gameover.enabled = true;
        }
    }
}

