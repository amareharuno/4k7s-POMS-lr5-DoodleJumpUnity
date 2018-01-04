using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour {

    public Transform target;
    public GameObject gameOver;
	
	void LateUpdate () {
        if (target.position.y > transform.position.y) {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
        }

        if (transform.position.y - target.position.y > 5) {
            Application.LoadLevel("GameOver");
        }
	}
}
