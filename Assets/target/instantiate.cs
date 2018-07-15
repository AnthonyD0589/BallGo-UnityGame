using UnityEngine;
using System.Collections;

public class instantiate : MonoBehaviour {

	public GameObject origtarget;
	float displayery;
	float displayerx;
	public bool startpos = true;


	// Update is called once per frame
	void Update () {

		if (startpos) {
			
			print ("works!");
			Vector3 intPos = GameObject.Find("mainobject").transform.position;
			intPos = new Vector3 (displayerx, displayery, 0);
			displayery += 4;
			displayerx = Random.Range (-4f, 4f); 
			GameObject redIns = Instantiate (origtarget) as GameObject;
			redIns.transform.position = intPos;

			startpos = false;
		}
	
	}
}
