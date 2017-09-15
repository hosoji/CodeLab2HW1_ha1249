using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

	public float zOffset = 10f;

	void Start(){
		Cursor.visible = false;
	}

	void Update () {
		Vector3 cursorPos = Input.mousePosition;
		cursorPos.z = zOffset;
		transform.position = Camera.main.ScreenToWorldPoint(cursorPos);
	}
}
