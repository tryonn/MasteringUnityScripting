using UnityEngine;
using System.Collections;

public class EnumAndSwitchBehaviourScript : MonoBehaviour
{
    #region aprendendo sobre enum

    // Define possible states for enemy using an enum
    public enum EnemyState { CHASE, FLEE, FIGHT, HIDE }

    // the current state of enemy
    public EnemyState ActiveState = EnemyState.CHASE;

    #endregion

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        #region aprendendo sonbre switch

        // Check the ActiveState variable
        switch (ActiveState)
        {
            case EnemyState.FIGHT:
                //Perform figth code here
                Debug.Log("Entered figth state");
                break;

            case EnemyState.HIDE:
                break;

            case EnemyState.FLEE:
                // Flee and hide performs the same behaviour
                Debug.Log("Entered flee or hide state");
                break;

            default:
                //default case when all other states fail
                //this is used for the chase state
                Debug.Log("Entered chase state");
                break;
        }

        #endregion
    }
}
