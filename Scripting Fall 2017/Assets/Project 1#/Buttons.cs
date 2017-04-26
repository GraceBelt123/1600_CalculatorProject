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
    float number;
    public Text randomNum;
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

    void Start()
    {
        number = Random.Range(1, 9);
        randomNum.text += number.ToString();
    }
}