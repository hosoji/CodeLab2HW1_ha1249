using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public virtual Vector3 Direction(Vector3 targetPos){
		return Vector3.zero;
	}
}
