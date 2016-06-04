using UnityEngine;
using System.Collections;
using System;

public class FunctionsBehaviourScript : MonoBehaviour
{
    #region
    //Private variable for score
    //Acessible only within this class
    private int score = 0;
    #endregion

    #region  special functions that Unity provides,

    // Use this for initialization
    void Start ()
    {
        //Call update score
        UpdateScore(5, false); //Add five points
        UpdateScore(10, false); //Add ten points

        int CurrentScore = UpdateScore(15, false); //Add fifteen points and store result


        //Now double score
        UpdateScore(CurrentScore);
	
	}

    // Update is called once per frame
    void Update()
    {

    }
    #endregion

    #region função personalizada chamada a cada frame
    private int UpdateScore(int AmountToAdd, bool PrintToConsole = true)
    {
        //Add points to score
        score += score;

        //Should we print to console?

        if (PrintToConsole)
        {
            Debug.Log("Score is : " + score.ToString());
        }

        //Output current score and exit function
        return score;
    }
    #endregion
}
