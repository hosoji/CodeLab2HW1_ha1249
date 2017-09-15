using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	float xPosMin = -6.5f;
	float xPosMax = 6.5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawning", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawning(){
		GameObject ball = GetComponent<AddColor> ().GenerateRandomBall ();

		Vector3 spawnPos = new Vector3 (Random.Range (xPosMin, xPosMax), transform.position.y, transform.position.z);
		ball.transform.position = spawnPos;

		ball.AddComponent<Rigidbody> ();
		ball.AddComponent<BallCollision> ();

		ball.GetComponent<Rigidbody> ().drag = 1f;
	}
}
