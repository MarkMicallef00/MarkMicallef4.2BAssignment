using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float paddleSpeed = 0.5f;
	public Vector3 playerPosition;

	// Update is called once per frame
	void Update () 
	{
		float yPos = gameObject.transform.position.y + (Input.GetAxis ("Vertical") * paddleSpeed);
		playerPosition = new Vector3 (-20, Mathf.Clamp(yPos, -12F, 12F), 0);
		gameObject.transform.position = playerPosition;
			
	}
}
