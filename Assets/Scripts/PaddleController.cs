using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

    public Camera cam;

    public float speed = 0.1f;
    public float moveSpeed = 0.1f;
    public float moveTargetGoalY;
    public float velocityYSmoothing;

    Vector3 moveTarget;



    // Use this for initialization
    void Start () {
	    if (!cam) {
            cam = Camera.main;
        }
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0F);
	}
	
	// Update is called once per frame
	void Update () {
        float moveTargetGoalY = Input.GetAxisRaw("Vertical") * moveSpeed;
        moveTarget.y = Mathf.SmoothDamp(moveTarget.y, moveTargetGoalY, ref velocityYSmoothing, speed);
        Move(moveTarget);
	}

    public void Move(Vector3 move){
        Vector3 pos = transform.position;

        transform.Translate(move);
    }
}
