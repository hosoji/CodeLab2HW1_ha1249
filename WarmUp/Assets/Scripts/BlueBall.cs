using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : Ball {
	public override Vector3 Direction (Vector3 targetPos) {
		Vector3 newDir = new Vector3 (targetPos.x-0.75f, targetPos.y, targetPos.z);
		return newDir;
	}

}
