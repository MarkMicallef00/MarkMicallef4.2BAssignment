using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 4;
    private Vector3 TargetPos;
    Vector3 obsPosition;
    private GameObject ballObject;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        ballObject = GameObject.FindGameObjectWithTag("Ball");
        if(ballObject != null)
        {
            TargetPos = Vector3.Lerp(gameObject.transform.position, ballObject.transform.position, Time.deltaTime * speed);
            obsPosition = new Vector3(-11, Mathf.Clamp(TargetPos.y, -12F, 12F), 0);
            gameObject.transform.position = new Vector3(0, obsPosition.y, 0);
        }
        
        
    }
}
