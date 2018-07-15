using UnityEngine;
using System.Collections;

public class cameratest : MonoBehaviour {

	public GameObject player;
	Vector3 shouldPos;
	float time = 2.5f;

	
	// Update is called once per frame
	void Update () 
	{
		shouldPos = Vector3.Lerp (gameObject.transform.position, player.transform.position, Time.deltaTime * 2.5f);
		gameObject.transform.position = new Vector3 (shouldPos.x, shouldPos.y, -10);
	}
}
