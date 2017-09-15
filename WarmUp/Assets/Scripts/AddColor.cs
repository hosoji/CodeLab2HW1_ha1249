using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddColor : MonoBehaviour {

	public GameObject [] balls;

	public GameObject GenerateRandomBall(){

		GameObject ball = Instantiate (balls [Random.Range (0, balls.Length)], transform.position, Quaternion.identity);

		return ball;
	}


}
