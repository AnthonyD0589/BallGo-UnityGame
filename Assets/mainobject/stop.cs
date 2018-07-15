using UnityEngine;
using System.Collections;

public class stop : MonoBehaviour {
	private Rigidbody2D rigi1;

	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.tag == "target") 
		{
			rigi1.velocity = Vector2.zero;
			print ("STOP!");
		}

	}
}