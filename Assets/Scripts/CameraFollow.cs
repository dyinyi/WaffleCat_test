﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	Camera mycam;

	// Use this for initialization
	void Start () {

		mycam = GetComponent<Camera> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		//mycam.orthographicSize = (Screen.height / 100f) / 4f;


		if (target) {

			transform.position = Vector2.MoveTowards (transform.position, target.position, 0.1f);

		} 

	
	}
}