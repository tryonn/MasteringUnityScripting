using UnityEngine;
using System.Collections;

public class EventsBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Rotate object by 2 degrees per frame around the Y axis

        transform.Rotate(new Vector3(0.0f, 2.0f, 0.0f));	
	}
}
