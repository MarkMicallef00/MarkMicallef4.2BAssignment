using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public TextMesh currentScore;
    public GameObject ballPrefab;
    public Transform paddleObject;

    private GameObject ball;
    private int score;

	// Update is called once per frame
	void Update ()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currentScore.text = "" + score;
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            score += 1;
            Destroy(ball);
            (Instantiate(ballPrefab, new Vector3(paddleObject.transform.position.x + 2, paddleObject.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObject;
        }
        if(score == 3)
        {
            Application.LoadLevel(2);
        }
    }
}
