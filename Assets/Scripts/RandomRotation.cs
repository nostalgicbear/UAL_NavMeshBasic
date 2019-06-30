using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Quaternion randomRotation = Random.rotation;


        transform.rotation = new Quaternion(transform.rotation.x, randomRotation.y, transform.rotation.z, transform.rotation.w);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
