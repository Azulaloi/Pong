using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    public GameObject ball;

	void Start () {
        
	}
	
	void Update () {
		if (!ball.activeSelf) {
            MoveBall();
        }
	}

    void MoveBall() {
        Vector3 ballOrigin = new Vector3(0, 0, 0);
        Quaternion ballRotation = Quaternion.identity;
        //Instantiate(ball, ballOrigin, ballRotation);
        ball.GetComponent<Transform>().SetPositionAndRotation(ballOrigin, ballRotation);
        ball.AddComponent<BallHandler>();
        ball.SetActive(true);
    }
}
