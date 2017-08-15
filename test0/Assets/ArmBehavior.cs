using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmBehavior : MonoBehaviour {
	public int speed =1;
	public Vector3 collisonPoint; 
	Vector3 axis = new Vector3 (0, 0, -1);
	// Use this for initialization
	public GameObject wall;
	void Start () {

	}
	 
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)==true){
			 transform.Rotate(Vector3.right*speed);
		}
		if(Input.GetKey(KeyCode.DownArrow)==true){
			transform.Rotate(Vector3.left*speed);
		}
		
	}

    void OnTriggerEnter(Collider col) {
		/*
		Vector3 incomingVector=direct;
		incomingVector = incomingVector.normalized;
		Vector3 normalVector = col.contacts[0].normal;
		Vector3 reflectVector = Vector3.Reflect (incomingVector, normalVector);
		reflectVector = reflectVector.normalized;
		*/
		//Debug.Log ("OnTriggerEnter");
    }



}
