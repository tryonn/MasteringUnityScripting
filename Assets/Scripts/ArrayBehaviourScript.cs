using UnityEngine;
using System.Collections;

public class ArrayBehaviourScript : MonoBehaviour
{
    #region aprendendo sobre array
    //Array of game objects in the scene
    public GameObject[] MyObjects;
    #endregion

    // Use this for initialization
    void Start ()
    {
        #region adicionando dados ao array manualmente
        //Build the array manually in code
        MyObjects = new GameObject[3];
        //Scene must have a camera tagged as MainCamera
        MyObjects[0] = Camera.main.gameObject;

        //Use GameObject.Find function to find objects in scene by name
        MyObjects[1] = GameObject.Find("Cylinder").gameObject;
        MyObjects[2] = GameObject.Find("Sphere").gameObject;

        #endregion

        #region removendo dados do array

        //Remove objects of array
        //Repeat code for all objects in array, one by one
        foreach (GameObject item in MyObjects)
        {
            Debug.Log("destroy objects" + item.gameObject.name);
            Destroy(item);
        }

        //Outra maneira de remover os objects do array
        for (int i = MyObjects.Length - 1; i >= 0; i--)
        {
            Destroy(MyObjects[i]);
        }

        #endregion

    }

    // Update is called once per frame
    void Update () {
	
	}
}
