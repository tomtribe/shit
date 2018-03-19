using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController001 : MonoBehaviour {

    public float speed = 10.0F;
    public float rotationspeed = 100.0F;

	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis ("Vertical") * speed;
        float rotation = Input.GetAxis ("Horizontal") * rotationspeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
 
	}
}
