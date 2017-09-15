using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBall : Ball {
	public override Vector3 Direction (Vector3 targetPos) {
		Vector3 newDir = new Vector3 (targetPos.x, targetPos.y - 0.75f, targetPos.z);
		return newDir;
	}

}
