using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour {
    public float speed = 10;

	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed; 
	}
	
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Paddle") {
            float f = (transform.position.y - collision.transform.position.y) / collision.collider.bounds.extents.y;
            Vector2 dir = new Vector2(-1, f).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
}
