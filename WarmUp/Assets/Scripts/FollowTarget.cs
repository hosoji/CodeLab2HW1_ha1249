using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

	public Transform target;
	public float speed = 3;


	void Update () {
		
		Vector3 dir = target.position - transform.position;

		Vector3 offset = new Vector3 (target.position.x , target.position.y - 1f, target.position.z);

		Vector3 dirOffset = offset - transform.position;


		transform.position += dirOffset * speed * Time.deltaTime;

	}
}
