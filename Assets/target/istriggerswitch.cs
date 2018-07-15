using UnityEngine;
using System.Collections;

public class istriggerswitch : MonoBehaviour {

	public bool iscreated = false;
	private Collider2D colli;

	// Use this for initialization
	void Start() {
		GetComponent<Collider2D> ().enabled = true;
		GetComponent<Rigidbody2D> ().isKinematic = true;
		this.gameObject.tag = "Untagged";

	}

	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "mainobject") 
		{
			iscreated = true;			// set the flick option on

		}

		if (iscreated) {
			GetComponent<Collider2D>().enabled = false;
			iscreated = false;
			//print ("istrigger off");
		}
	}
}

