using UnityEngine;
using System.Collections;

public class crab_script : MonoBehaviour {

	Rigidbody2D rb;
	//public Vector2 position;
	//public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//position = this.GetComponent<Transform>().position;

		//transform.Translate (Vector2.right*speed);
	}
	
	// Update is called once per frame
	void Update () {
		/*this.GetComponent<Transform> ().position = position;
		if (Input.GetAxisRaw ("Horizontal") > 0) {
			position.x = position.x + speed;
		}
		if (Input.GetAxisRaw ("Horizontal") < 0) {
			position.x = position.x - speed;
		}
		if (Input.GetAxisRaw ("Vertical") > 0) {
			position.y = position.y + speed;
		}
		if (Input.GetAxisRaw ("Vertical") < 0) {
			position.y = position.y - speed;
		}*/
		/*if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector2.right * speed);
		}
		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector2.left * speed);
		}
		if (Input.GetAxisRaw ("Vertical") > 0) {
			transform.Translate (Vector2.up * speed);
		}
		if (Input.GetAxisRaw ("Vertical") < 0) {
			transform.Translate (Vector2.down * speed);
		}*/
	}
void OnCollisionEnter2D(Collision2D coll){
	}
}

