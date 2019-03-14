using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour {

    public Transform t;
    public Vector3 movement = new Vector3();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        t.position = t.position + movement * Time.deltaTime;
		
	}
}
