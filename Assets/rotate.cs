using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour 
{
	public float speed = 3;
	public bool speedon = true;

	// Update is called once per frame
	void Start()
	{
		transform.rotation = Quaternion.identity;
	}

	void Update () 
	{
		if (speedon) 
		{
			transform.Rotate (speed, speed, speed);
		}
		//speedon = false;
	}
}