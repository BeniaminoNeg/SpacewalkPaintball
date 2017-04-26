//Beniamino Negrini 16203019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circulMoving : MonoBehaviour {

	Quaternion rotation;
	Vector3 radius = new Vector3(5,0,0);
	float currentRotation = 0.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentRotation += Input.GetAxis("Horizontal")*Time.deltaTime*100;
		rotation.eulerAngles = new Vector3(0, currentRotation, 0);
		transform.position = rotation * radius;
	}
}
