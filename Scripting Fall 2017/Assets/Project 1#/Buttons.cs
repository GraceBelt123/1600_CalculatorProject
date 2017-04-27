using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class Buttons : MonoBehaviour
{
    //Random.Range() == public void Lucky.
    //Need to figure what to do with Arrays. Maybe. It seem to be restored collection. 
    public InputField Sir;
    public InputField super;
    public InputField dogs;
	float number = 0f;
    public Text randomNum;
	public Text randomnum2;
	public Text randomnum3;
	public Text randomnum4;
    public Display wonNum;


    public void AddButton()
    {
        float sum;
        sum = float.Parse(Sir.text) + float.Parse(super.text);
        dogs.text = sum.ToString();
    }

    public void AddCharacter()
    {
        float sub;
        sub = float.Parse(Sir.text) - float.Parse(super.text);
        dogs.text = sub.ToString();
    }

    public void AddBalls()
    {
        float multiple;
        multiple = float.Parse(Sir.text) * float.Parse(super.text);
        dogs.text = multiple.ToString();
    }

    public void AddDays()
    {
        float divide;
        divide = float.Parse(Sir.text) / float.Parse(super.text);
        dogs.text = divide.ToString();
    }

	public void ButtonPressed()
	{
		Sir.text += this.gameObject.name;
	}

    void Start()
    {
        number = Random.Range(1, 9);
        randomNum.text += number.ToString();
    }
	//get the text component of the button and assign a variable to it.
		// check to see what that variable is,(switch statement) and based on that nunber we want to change what is in the input feild. 
		//1) the text of the button
		//2) the text of the input field

}