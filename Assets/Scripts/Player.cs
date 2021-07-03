using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	public float speed = 4f;
	public Rigidbody2D rb;
	float movement = 0;

	void Start () {
		
	}
	
	void Update () {
		movement = Input.GetAxisRaw ("Horizontal") * speed;
	}

	void FixedUpdate(){
		rb.MovePosition (rb.position + Vector2.right * movement * Time.fixedDeltaTime);
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.collider.CompareTag("Ball") || col.collider.CompareTag("Last Ball")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
