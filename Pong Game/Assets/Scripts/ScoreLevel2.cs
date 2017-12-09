using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLevel2 : MonoBehaviour
{

    public TextMesh currentScore;
    public GameObject ballPrefab;
    public Transform paddleObject;

    private GameObject ball;
    private int score2;

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currentScore.text = "" + score2;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            score2 += 1;
            Destroy(ball);
            (Instantiate(ballPrefab, new Vector3(paddleObject.transform.position.x + 2, paddleObject.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObject;
        }
        if (score2 == 5)
        {
            Application.LoadLevel(3);
        }
    }
}
