using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorings : MonoBehaviour {

    public TextMesh currentBoolean;
    public GameObject ballPrefeb;
    public Transform paddleObject;

    GameObject ball;
    int score;

	// Update is called once per frame
	void Update () {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currentBoolean.text = "" + score;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ball")
        {
            score += 1;
            Destroy(ball);
            (Instantiate(ballPrefeb, new Vector3(paddleObject.transform.position.x + 2, paddleObject.transform.position.y,0), Quaternion.identity)as GameObject).transform.parent = paddleObject;
        }
    }
}
