using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour {
	Ball ball;

	void OnTriggerEnter2D (Collider2D col) {
		Chain.IsFired = false;

		if (col.CompareTag("Ball")) {
			col.GetComponent<Ball> ().Split ();
		}

		else if (col.CompareTag("Last Ball")) {
			Destroy (col.gameObject);
		}
	}
}
