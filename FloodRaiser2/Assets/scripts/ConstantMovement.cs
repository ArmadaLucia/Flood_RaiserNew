using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour {

    public Transform t;
    public Vector3 movement = new Vector3();
	
	// Update is called once per frame
	public void WaterMoving () {

        t.position = t.position + movement * Time.deltaTime;
		
	}
}
