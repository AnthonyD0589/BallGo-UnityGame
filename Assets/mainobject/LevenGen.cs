using UnityEngine;
using System.Collections;

public class LevenGen : MonoBehaviour 
{
	public bool spawn = false;
	public bool firstspawn = true;

	public GameObject target1;
	public GameObject target2;
	public GameObject targetprefab;

	int firstRand;
	int secondRand;
	float displayery;
	float displayerx;
	float displayery2;
	float displayerx2;
	float displayerorigy;
	float displayerorigx;

	//private Vector3 pos1 = new Vector3(-4, 0, 0);
//private Vector3 pos2 = new Vector3(4, 0, 0);
	//public float speed = 500.0f;

	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "target 1(Clone)") 
		{
			spawn = true;

		}
		if (coll.gameObject.name == "target(Clone)") 
		{
			spawn = true;
		}
			
	}

	void Update () 
	{
		if (firstspawn) {                 // ADD THIS SECTION TO VITH SCRIPPTT!!!!

			Vector3 intPosorig = GameObject.Find("mainobject").transform.position;
			displayerorigy += 1;
			displayerorigx = Random.Range (-2f, 2f); 
			intPosorig = new Vector3 (displayerorigx, displayerorigy, 0);
			GameObject startIns = Instantiate (targetprefab) as GameObject;
			startIns.transform.position = intPosorig;

			firstspawn = false;
		}

		if (spawn) 
		{

			firstRand = Random.Range (1,3); // doesn't use last number

			if(firstRand==1)
			{
				{	
					Vector3 intPos = GameObject.Find("mainobject").transform.position;
					displayery += Random.Range (4f, 5f);
					displayerx = Random.Range (-2f, 2f); 
					intPos = new Vector3 (displayerx, displayery, 0);
					GameObject redIns = Instantiate (target1) as GameObject;
					redIns.transform.position = intPos;
					spawn = false;

				}
			}

			if (firstRand ==2) 
				{
					Vector3 intPos2 = GameObject.Find("mainobject").transform.position;
					displayery += Random.Range (3f, 5f);
					displayerx = Random.Range (-2f, 2f);	
					intPos2 = new Vector3 (displayerx, displayery, 0); 
					GameObject blueIns = Instantiate (target2) as GameObject;
					blueIns.transform.position = intPos2;
					spawn = false;

				} 
			
			}

		}
}

