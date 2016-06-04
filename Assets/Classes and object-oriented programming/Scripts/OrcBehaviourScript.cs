using UnityEngine;
using System.Collections;

public class OrcBehaviourScript : MonoBehaviour
{
    //Reference to the transform component of orc (position, rotation, scale)
    private Transform _transform = null;

    //Enum for state of orc
    public enum OrcSate {NEUTRAL, ATTACK_MELEE, ATTACK_RANGE};

    //Current state orc
    private OrcSate currentState = OrcSate.NEUTRAL;

    //Movement speed of orc in meters per second
    public float OrcSpeed = 10.0f;

    //Is orc friedly to player
    public bool isFriendly = false;

    // Use this for initialization
    void Start ()
    {
        //Get transform for orc
        _transform = transform;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //State actions for orc
    public void AttackMelee()
    {
        //Do melee attack here
    }

    public void AttackRange()
    {
        //Do range attack here
    }

}
