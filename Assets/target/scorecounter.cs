using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour {

	public Text countText;
	private int count;

	void OnCollisionEnter2D (Collision2D coll)
	{ 
		if (coll.gameObject.name == "target 1(Clone)") 
		{
			count = count + 1;
			SetCountText ();
		}

		if (coll.gameObject.name == "target(Clone)") 
		{
			count = count + 1;
			SetCountText ();
		}

	}
	// Use this for initialization
	void Start () {
		count = 0;
		SetCountText ();
		
	}
	
	// Update is called once per frame
	void SetCountText()
	{
		countText.text = "" + count.ToString ();
	}
		
}
