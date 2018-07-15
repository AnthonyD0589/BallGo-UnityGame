using UnityEngine;
using System.Collections;

public class movetowardt : MonoBehaviour {

	public float time;
	public float speed;
	public float time1 = 1.0f;

	private GameObject targeton;

	public bool move = false;

	private Transform moveto;

	public Rigidbody2D rb;


	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "target 1(Clone)") 
		{
			targeton = coll.gameObject;
			targeton.gameObject.tag = "target";
			move = true;

		}

		if (coll.gameObject.name == "target(Clone)") 
		{
			targeton = coll.gameObject;
			targeton.gameObject.tag = "target";
			move = true;

		}

	}

	// Update is called once per frame
	void Update () {

		if (move) {
			moveto = GameObject.FindGameObjectWithTag ("target").transform;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, moveto.position, step);
			transform.position = moveto.transform.position;

			time += Time.deltaTime;

		}

		if (Input.GetMouseButton(0)) {
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if(hit.collider.gameObject.name == "mainobject")
			{
					print ("ggg");
					targeton.gameObject.tag = "Untagged";
	
					time = 0.0f;
					move = false;
				}



		}
}
}

