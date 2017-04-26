//Beniamino Negrini 16203019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovements : MonoBehaviour {

	private Rigidbody rb;

	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		bool pressedX = false;
		bool pressedZ = false;

		if (Input.GetKey (KeyCode.X)) {
			print("Sto nella XPREMUTA");
			pressedX = true;
		}

		if (Input.GetKey (KeyCode.Z)) {
			print ("Sto nella ZPREMUTA");
			pressedZ = true;
		}

		float x, y, z;

		x = 0;
		y = 0;
		z = 0;

		if (pressedX || pressedZ) {
			print ("Cambio la Z");
			z = 6;
		}



		Vector3 movement = new Vector3 (x, y, z);
		rb.AddForce (movement * speed);

			
	}
}
