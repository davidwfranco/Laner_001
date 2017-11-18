using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rdb2d;

    private float maxW;
    private float maxH;

	// Use this for initialization
	void Start () {
		rdb2d = GetComponent<Rigidbody2D> ();
        maxW = GameController.instance.maxWidth;
        maxH = GameController.instance.maxHeigth;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up")) 
		{
			rdb2d.transform.position = new Vector2 (0, maxH - (maxH / 3));
            Debug.Log(maxH);
		} 
		else if (Input.GetKeyDown("down"))
        {
            rdb2d.transform.position = new Vector2(0, -(maxH - (maxH / 3)));
        }
        else if (Input.GetKeyDown("left"))
        {
            rdb2d.transform.position = new Vector2(-(maxW - (maxW / 3)), 0);
        }
        else if (Input.GetKeyDown("right"))
        {
            rdb2d.transform.position = new Vector2((maxW - (maxW / 3)), 0);
        }
        else if (Input.GetKeyUp("up") || Input.GetKeyUp("down") || Input.GetKeyUp("left") || Input.GetKeyUp("right"))
        {
            rdb2d.transform.position = new Vector2(0, 0);
        }
	}
}
