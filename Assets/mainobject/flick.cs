using UnityEngine;
using System.Collections;

public class flick : MonoBehaviour {
	private const int VECTOR_COUNT = 5;
	private int vectorIndex = 0;
	private Vector3[] positionChanges;
	private Vector3 prevMousePosition;
	private float[] prevTimes;
	private bool curDown = false;
	private bool prevDown = false;
	private bool stop = false;
	private Rigidbody2D rigi;
	public float speed = 1f;

	// Use this for initialization

	void Start () {
		rigi = GetComponent<Rigidbody2D> ();
		prevMousePosition = Vector3.zero;
		positionChanges = new Vector3[VECTOR_COUNT];
		prevTimes = new float[VECTOR_COUNT];
		for (int i = 0; i < VECTOR_COUNT; i++) {
			positionChanges [i] = Vector3.zero;
			prevTimes [i] = 0;
		}
	}

	// Update is called once per frame
	void Update () {
		if (stop) {

			rigi.velocity = Vector2.zero;
			stop = false;

		}

		if (curDown) {
			Vector3 amountMoved = Camera.main.ScreenToWorldPoint (positionChanges [(vectorIndex - 1 + VECTOR_COUNT) % VECTOR_COUNT]) - Camera.main.ScreenToWorldPoint (new Vector2 (0, 0));

		} else if (prevDown) {
			//finger came up now calculate and set velocity
			float totalTime = 0;
			Vector3 totalDistance = Vector3.zero;
			Vector3 velocity;
			for (int i = 0; i < VECTOR_COUNT; i++) {
				totalTime += prevTimes [i];
				totalDistance += positionChanges [i];
			}
			velocity = (totalDistance / totalTime) * speed;   //	TTRRAAILL
			velocity = Camera.main.ScreenToWorldPoint (velocity) - Camera.main.ScreenToWorldPoint (Vector3.zero);
			rigi.velocity = velocity;
		}

		positionChanges [vectorIndex] = Input.mousePosition - prevMousePosition;
		prevTimes [vectorIndex] = Time.deltaTime;
		vectorIndex = (vectorIndex + 1) % VECTOR_COUNT;

		prevDown = curDown;
		prevMousePosition = Input.mousePosition;


		/*if (!curDown) {
             Vector2 temp = GetComponent<Rigidbody2D>().velocity;
             if((transform.position.y > Camera.main.orthographicSize && GetComponent<Rigidbody2D>().velocity.y > 0) ||
                 (transform.position.y < -Camera.main.orthographicSize && GetComponent<Rigidbody2D>().velocity.y < 0))
                 temp.y *= -1;
             if((transform.position.x > Camera.main.orthographicSize * Camera.main.aspect && GetComponent<Rigidbody2D>().velocity.x > 0) ||
                (transform.position.x < -Camera.main.orthographicSize * Camera.main.aspect && GetComponent<Rigidbody2D>().velocity.x < 0))
                 temp.x *= -1;
 
             GetComponent<Rigidbody2D>().velocity = temp;
         } */

	}

	void OnMouseDown() {
		//print ("down");
		curDown = true;
		rigi.velocity = Vector2.zero;
	}

	void OnMouseUp() {
		//print ("up");
		curDown = false;
		rigi.velocity = Vector2.zero;
	}

}

