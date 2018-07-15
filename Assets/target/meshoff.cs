using UnityEngine;
using System.Collections;

public class meshoff : MonoBehaviour {
	public Renderer rend;

	void Start()
	{
		rend = GetComponent <Renderer> ();
		rend.enabled = true;
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "mainobject") 
		{
			rend = GetComponent <Renderer> ();
			rend.enabled = false;
		}
	}
}
