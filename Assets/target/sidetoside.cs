using UnityEngine;
using System.Collections;

public class sidetoside : MonoBehaviour  
{

	public float min=2f;
	public float max=2f;
	public float speed;

	void Start ()
	{
		min = transform.position.x - 4;
		max = transform.position.x;
		speed = 1f;
	}

	void Update () 
	{
		transform.position = new Vector3 (Mathf.PingPong (Time.time * speed, max - min) + min, transform.position.y, transform.position.z);
	}
} 