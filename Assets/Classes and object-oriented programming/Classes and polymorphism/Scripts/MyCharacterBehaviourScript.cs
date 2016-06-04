using UnityEngine;
using System.Collections;

public class MyCharacterBehaviourScript
{
    public string CharName = "";
    public int Health = 100;
    public int Strength = 100;
    public float Speed = 10.0f;
    public bool isAwake = false;

    //Offer greeting to the player when  entering conversation
    public virtual void SayGreeting()
    {
        Debug.Log("Hello, my friend");
    }
}
