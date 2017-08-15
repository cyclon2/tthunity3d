using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBehavior : MonoBehaviour {
	public int speed =1;
	public Vector3 collisonPoint; 
	Vector3 axis = new Vector3 (0, 0, -1);
	// Use this for initialization
	public GameObject wall;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider col){
		Debug.Log ("child : "+Vector3.Project((collisonPoint-transform.position),axis));
	}
	void OnTriggerExit(Collider col){
		Debug.Log ("object Out!");
		wall.GetComponent<BoxCollider> ().isTrigger = false;
	}
	void OnCollisionEnter(Collision collision) {
		collisonPoint = collision.contacts [0].point;
		Debug.Log ("collison point : "+collision.contacts[0].point);
		Debug.Log ("project vector : "+Vector3.Project(collision.contacts[0].point, axis));
		wall.GetComponent<BoxCollider> ().isTrigger = true;
	}
	void OnCollisionExit(Collision collision){

	}
	void OnCollisonStay(Collision collision){

	}
	void OnApplicationQuit(){

	}
}
