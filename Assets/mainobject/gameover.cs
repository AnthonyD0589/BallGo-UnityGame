using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {

	public float time = 0f;

	public bool timelimit = false;

	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "target 1(Clone)") {

			time = 0f;

		}

		if (coll.gameObject.name == "target(Clone)") {

			time = 0f;

		}
	}

	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

			if (hit.collider.gameObject.name == "mainobject") {
				timelimit = true;
			}
		}

		if (timelimit) 
		{
			time += Time.deltaTime;
				
		}

		if (time > 10f) {
			Application.LoadLevel (0);
		}

		
	
	}
}

