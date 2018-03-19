using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    public GameObject Door;
    public bool opening;

	// Use this for initialization
	void Start () {
		
	}
	//create a script that detect our mouse click on the button, than will translate the mouse up 
	// Update is called once per frame
	void Update () {
		if(opening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
        if(Door.transform.position.y > 7f)
        {
            opening = false;
        }
	}

    //On click listener
    private void OnMouseDown()
    {
        opening = true;

    }
}
