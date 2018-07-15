using UnityEngine;
using System.Collections;

public class deathparticle : MonoBehaviour {

	public ParticleSystem burst;
	public bool bursttoggle = false;
	public bool timertoggle = false;
	public float timerdp = 0.0f;

	// Use this for initialization
	void Start () 
	{
		burst.GetComponent<ParticleSystem> ().enableEmission = false;
	}

	void Update() 
	{
		if (timertoggle)
		{
			timerdp += Time.deltaTime;
		}

		if (timerdp > 4f) {

			burst.GetComponent<ParticleSystem> ().enableEmission = true; // place where the burst occurs
			StartCoroutine (stopburst ());
			timerdp = 0f;
			timertoggle = false;
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "target(Clone)") 
		{
			timertoggle = true;
		}

		if (coll.gameObject.name == "target 1(Clone)") 
		{
			timertoggle = true;
		}
	}

	IEnumerator stopburst()
	{
		yield return new WaitForSeconds (0.10f);
		burst.GetComponent<ParticleSystem> ().enableEmission = false;
		this.gameObject.GetComponent<Renderer> ().enabled = false;
	}
	// Update is called once per frame
}

