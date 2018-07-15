using UnityEngine;
using System.Collections;

public class centertagswitch : MonoBehaviour {

	private GameObject centeroff;

	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "mainobject") 
		{
			//print ("good");
			centeroff = GameObject.FindGameObjectWithTag ("centeroff");
			centeroff.gameObject.tag = "center";

		}
	}
}
