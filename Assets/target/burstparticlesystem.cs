using UnityEngine;
using System.Collections;

public class burstparticlesystem : MonoBehaviour {

	public ParticleSystem burst;

	// Use this for initialization
	void Start () {
		burst.GetComponent<ParticleSystem> ().enableEmission = false;
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "mainobject") 
		{
			burst.GetComponent<ParticleSystem> ().enableEmission = true;
			StartCoroutine (stopburst ());
			//print ("lol");
		}
	}

	IEnumerator stopburst()
	{
		yield return new WaitForSeconds (0.15f);
		burst.GetComponent<ParticleSystem> ().enableEmission = false;
	}
	// Update is called once per frame

}
