using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Beniamino Negrini 16203019
public class MoveObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("SetRandomPos",0f,0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetRandomPos() {
		
		Vector3 delta = new Vector3(Random.Range(-0.1f,0.1f),Random.Range(-0.1f,0.1f),Random.Range(-0.1f,0.1f));

		Vector3 attuale = transform.position;

		transform.position = attuale + delta;

	}
}
