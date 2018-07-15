using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

	public GameObject attractedTo;
	private GameObject center;
	private GameObject truecenter;

	public float strengthOfAttraction = 0f;
	public float time = 0f;

	public bool gravitypull = false;
	public bool followcenter = false;


	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "targetgravityrange") 
		{
			gravitypull = true;			// set the flick option on
			//print ("pull");
		}
		if (coll.gameObject.name == "center") 
		{
			gravitypull = false;
			// set the flick option on
			//print ("followcenter");
		}
			
	}

	void Update()
	{
			
		if (gravitypull) {

			strengthOfAttraction = 500.0f;

			attractedTo = GameObject.FindGameObjectWithTag ("center");

			//print ("go");

			Vector3 direction = attractedTo.transform.position - transform.position;
			GetComponent<Rigidbody2D> ().AddForce (strengthOfAttraction * direction);


		}
			
	}
}