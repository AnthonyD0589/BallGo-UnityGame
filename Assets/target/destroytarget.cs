using UnityEngine;
using System.Collections;

public class destroytarget : MonoBehaviour {

	public bool destroytrgt;
	public float time = 0f;

	// Use this for initialization
	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "mainobject") 
		{
			destroytrgt = true;
		}

	}
	void Start () {
	
		destroytrgt = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (destroytrgt) {
			
			time += Time.deltaTime;


			if (time > 6) {

				Destroy(this.gameObject);
			
			}
		}
	
	}
}
