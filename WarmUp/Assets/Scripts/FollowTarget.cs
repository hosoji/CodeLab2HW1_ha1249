﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

	public Transform target;
	float speed = 10f;


	void Update () {
		
//		Vector3 offset = new Vector3 (target.position.x , target.position.y - 1f, target.position.z);

		Vector3 dir = GetComponent<Ball> ().Direction(target.position);
		Vector3 dirOffset = dir - transform.position;
		transform.position += dirOffset * speed * Time.deltaTime;

	}
}
