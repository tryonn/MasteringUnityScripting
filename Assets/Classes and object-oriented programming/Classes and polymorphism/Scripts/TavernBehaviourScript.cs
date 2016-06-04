using UnityEngine;
using System.Collections;
using System;

public class TavernBehaviourScript : MonoBehaviour
{
    //Array of Npcs in tavern
    public MyCharacterBehaviourScript[] Characters = null;

	// Use this for initialization
	void Start ()
    {
        //New array - 5 NPCs in tavern
        Characters = new MyCharacterBehaviourScript[5];

        //Add characters of different types to array MyCharacterBehaviourScript
        Characters[0] = new ManCharacterBehaviourScript();
        Characters[1] = new WomanCharacterBehaviourScript();
        Characters[2] = new OrcCharacterBehaviourScript();
        Characters[3] = new WomanCharacterBehaviourScript();
        Characters[4] = new ManCharacterBehaviourScript();


        //Now run tavern functionality
        EnterTavern();

    }

    //Function when player enters tavern
    private void EnterTavern()
    {
        //EveryBody say greeting
        foreach (MyCharacterBehaviourScript charac in Characters)
        {
            //call SayGreeting in derived class
            //Derived class is accessible via base class
            charac.SayGreeting();
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
