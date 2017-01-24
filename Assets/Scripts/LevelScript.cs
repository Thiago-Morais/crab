using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {

	Rigidbody2D ballrb;
	public GameObject barra;
	public GameObject ball;
	public GameObject brick;
	public GameObject target;
	public GameObject pointer;
	public GameObject angulador;
	public GameObject spiner;
	public GameObject bouncerDad;
	public GameObject bouncerSon;
	public float Brrspeed;
	public float Vspeed;
	public float Hspeed;
	public float Ballspeed;
	public Camera camera;
	public Vector3 pos;
	public Vector3 odpos;
	public Vector2 ballPos;
	Vector2 mousePos;

	// Use this for initialization
	void Start () {
		ballrb = ball.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 targetPos = ball.transform.position;
		Vector3 targetPosFlattened = new Vector3(targetPos.x, targetPos.y, 0);
		pointer.transform.LookAt(targetPosFlattened);

		pos = Camera.main.ScreenToWorldPoint(barra.transform.position);
		odpos = Camera.main.WorldToScreenPoint (barra.transform.position);

	
		if (Input.GetAxisRaw ("Horizontal") > 0) {
			barra.transform.Translate (Vector2.right * Hspeed * Brrspeed);
		}
		if (Input.GetAxisRaw ("Horizontal") < 0) {
			barra.transform.Translate (Vector2.left * Hspeed * Brrspeed);
		}
		if (Input.GetAxisRaw ("Vertical") > 0) {
			barra.transform.Translate (Vector2.up * Vspeed * Brrspeed);
		}
		if (Input.GetAxisRaw ("Vertical") < 0) {
			barra.transform.Translate (Vector2.down * Vspeed * Brrspeed);
		}

		ballPos = ball.transform.position;

	//Andador muda "Ballspeed" pra 7f
		Ballspeed = Mathf.MoveTowards (Ballspeed, 4f, 2f * Time.deltaTime);
		//ball.transform.position = Vector2.MoveTowards (ballPos, target.transform.position, Ballspeed * Time.deltaTime);

	//Bouncer Stuff
	//	mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	//	bouncerDad.transform.position = mousePos;
		bouncerDad.transform.LookAt(ballPos);
	}

}
