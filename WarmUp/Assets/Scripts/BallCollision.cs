using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Ground") {
			Destroy (gameObject);
		}
	}

}
