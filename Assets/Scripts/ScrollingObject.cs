using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	private Rigidbody2D rdb2d;

    private float verticalSpeed;

	// Use this for initialization
	void Start () {
		// Get the RigidBody of this object
		rdb2d = GetComponent<Rigidbody2D> ();

		verticalSpeed = GameController.instance.bulletVSpeed;

		// Set its initial scrolling speed
		rdb2d.velocity = new Vector2(0.0f, verticalSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		//rdb2d.velocity = new Vector3(-10f, -10f, 0);
		//Debug.Log(rdb2d.velocity);
		if (GameController.instance.gameOver) {
		 rdb2d.velocity = Vector2.zero;
		}
	}
}
