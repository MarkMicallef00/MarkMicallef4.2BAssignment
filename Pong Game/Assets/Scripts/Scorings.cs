using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorings : MonoBehaviour
{

    public TextMesh currentBoolean;
    public GameObject ballPrefeb;
    public Transform paddleObject;

    GameObject ball;
    int score1;
    

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currentBoolean.text = "" + score1;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            score1 += 1;
            Destroy(ball);
            (Instantiate(ballPrefeb, new Vector3(paddleObject.transform.position.x + 2, paddleObject.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObject;
        }
        if (score1 == 3)
        {
            Application.LoadLevel(2);
        }
    }
}