using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour {
	public static bool IsFired = false;
	public Transform playerTransform;
	public float speed = 2;

	void Start(){
		IsFired = false;
	}

	void Update(){
		if (Input.GetButtonDown("Fire1")) {
			IsFired = true;
		}

		if (IsFired) {
			transform.localScale += Vector3.up * Time.deltaTime * speed;
		} 

		else {
			transform.position = playerTransform.position;
			transform.localScale = new Vector3 (0.3f, 0, 1);
		}
	}
}
