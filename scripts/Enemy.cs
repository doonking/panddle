﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed = 8;
	Vector3 targetPos;
	GameObject ballObj;


	// Use this for initialization
	void Start () {
		ballObj = GameObject.FindGameObjectWithTag ("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
		gameObject.transform.position = new Vector3 (22, targetPos.y, 0);	
	}
}
