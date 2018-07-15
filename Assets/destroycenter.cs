using UnityEngine;
using System.Collections;

public class destroycenter : MonoBehaviour {

	public bool iscreated;


	void Start() {

		GetComponent<Collider2D> ().enabled = true;
		GetComponent<Rigidbody2D> ().isKinematic = true;
		this.gameObject.tag = "centeroff";
	}
	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "mainobject") 
		{
			iscreated = true;			// set the flick option on
		}

		if (iscreated) {
			GetComponent<Collider2D>().enabled = false;
			GetComponent<Rigidbody2D> ().isKinematic = false;
			this.gameObject.tag = "Untagged";

		}
	}
}