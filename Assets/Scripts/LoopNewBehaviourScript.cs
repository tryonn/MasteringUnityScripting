using UnityEngine;
using System.Collections;

public class LoopNewBehaviourScript : MonoBehaviour
{
    private int NumberOfMessages;
    // Use this for initialization
    void Start ()
    {

        #region loop
        // Will count how many messages have been printed
        NumberOfMessages = 0;

        //Loop until 5 messages have beem printed to the console
        while (NumberOfMessages < 5)
        {
            //Print Message
            Debug.Log("This messages: " + NumberOfMessages.ToString());

            //Increment count
            ++NumberOfMessages;
        }
        #endregion
}

// Update is called once per frame
    void Update ()
    {
    }
}
