using UnityEngine;
using System.Collections;
using System;

//------------------------------------------------------
//Sample class - can be attached to object as a component
public class DatabaseBehaviourScript : MonoBehaviour
{
    //------------------------------------------------------
    //Public property for private variable iMyNumber
   public int MyNumber
    {
        //Called when retrieving value
        get
        {
            return iMyNumber;
        }
        //Calleg when setting value
        set
        {
            //if values is within 1-10, set number else  ignore
            if (value >= 1 && value <= 10)
            {
                //Update private variable
                iMyNumber = value;

                //Call event
                NumberChange();
            }
        }
    }
    //------------------------------------------------------
    //Internal reference a number between 1-10
    private int iMyNumber = 0;
    //--------------------------

    

    // Use this for initialization
    void Start ()
    {
        //Set My Number
        MyNumber = 11;//will fail because number > 10

        //Set My Number
        MyNumber = 7;//will succeed because number is between 1-10
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //------------------------------------------------------
    //Event called when myNumber is changed
    private void NumberChange()
    {
        Debug.Log("Variable iMyNumber changed to: " + MyNumber.ToString());
    }
    //------------------------------------------------------
}
//------------------------------------------------------
