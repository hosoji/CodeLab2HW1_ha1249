using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateColorTrail : MonoBehaviour {

	List <GameObject> body = new List<GameObject>();

	public int bodyLength = 3;

	void Start(){

		GameObject spawner = GameObject.Find ("BallSpawner");

		for (int i = 0; i < bodyLength; i++) {
			body.Add(spawner.GetComponent<AddColor> ().GenerateRandomBall ());
			body [i].AddComponent<FollowTarget> ();

			if (i > 0) {
				body [i].GetComponent<FollowTarget> ().target = body [i - 1].transform;
			} else {
				body [i].GetComponent<FollowTarget> ().target = transform;
			}
		}


	}

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit)){
				if (hit.transform.tag == "Ball") {
					hit.transform.gameObject.GetComponent<Rigidbody> ().isKinematic = true;
					hit.transform.gameObject.AddComponent<FollowTarget> ();
//					hit.transform.gameObject.GetComponent<SphereCollider> ().enabled = false;
					body.Add (hit.transform.gameObject);

//					Debug.Log ("Contact made");
					if (body.Count > 1) {
						hit.transform.gameObject.GetComponent<FollowTarget> ().target = body [body.Count - 2].transform;
					} else {
						hit.transform.gameObject.GetComponent<FollowTarget> ().target = transform;
					}
				}
				
			}
		}

	}

//	void OnTriggerEnter (Collider col){
//		if (col.gameObject.tag == "Ball") {
//			Debug.Log ("Contact");
//			col.gameObject.AddComponent<FollowTarget> ();
//			col.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;
//			body.Add (col.gameObject);
//			if (body.Count > 0) {
//				col.gameObject.GetComponent<FollowTarget> ().target = body [body.Count-1].transform;
//			} else {
//				col.gameObject.GetComponent<FollowTarget> ().target = transform;
//			}
//		}
//	}

}
