using UnityEngine;
using System.Collections;

public class kinematicswitch : MonoBehaviour {

	public Rigidbody2D rb;


	void Start() {
		rb = GetComponent<Rigidbody2D> ();
		rb.isKinematic = true;
		GetComponent<Collider2D> ().enabled = true;

	}

	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "mainobject") 
		{
			rb.isKinematic = false;			// set the flick option on
			foreach (Collider2D c in GetComponents<Collider2D>()) {
				c.enabled = false;
			}
			//print ("kinematicoff");
		}

	}

}
