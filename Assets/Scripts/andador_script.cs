using UnityEngine;
using System.Collections;

public class andador_script : MonoBehaviour {

	Rigidbody2D rb;
	public GameObject and;
	public GameObject pointer;
	public GameObject spiner;
	public GameObject mirror;
	public GameObject angulador;
	public GameObject bouncerSon;
	public GameObject levelManager;
	float barraAnglerZ;
	float bouncerAnglerZ;
	float mirrorX;
	float mirrorY;
	float mouseCos;
	float mouseSin;
	public float speed;
	bool bounce = false;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity=new Vector2(speed,0);
	}

	void Update () {
		/*Debug.Log (mouseCos);
		Debug.Log (mouseSin);
		Debug.Log (bouncerSon.transform.eulerAngles.z);
		Debug.Log (Mathf.Cos(bouncerSon.gameObject.transform.eulerAngles.z-90) *-speed);
		Debug.Log (Mathf.Sin(bouncerSon.gameObject.transform.eulerAngles.z) *-speed);
		Debug.Log (rb.velocity);*/
		Debug.Log (Mathf.Sin (30));
		Debug.Log (Mathf.Cos (30));
	//Polimento
		bouncerAnglerZ = angulador.transform.eulerAngles.z * -1 - 45;
		mirrorX = mirror.transform.localScale.x;
		mirrorY = mirror.transform.localScale.y;
		pointer.transform.localPosition = new Vector2 (rb.velocity.x,rb.velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other) {
		
	//Referente à barra
		if ((other.tag == "down") && (!Input.GetKey ("up"))) {
			spiner.transform.eulerAngles = new Vector3 (spiner.transform.eulerAngles.x, spiner.transform.eulerAngles.y, bouncerAnglerZ);
		}
		if ((other.tag == "up") && (!Input.GetKey ("down"))) {
			spiner.transform.eulerAngles = new Vector3 (spiner.transform.eulerAngles.x, spiner.transform.eulerAngles.y, bouncerAnglerZ);
		}

	

	//Detectar os bricks
		/*if (other.tag == "x+") {
			mirror.transform.localScale = new Vector2 (-1, mirrorY);
		}
		if (other.tag == "x-") {
			mirror.transform.localScale = new Vector2 (1, mirrorY);
		}
		if (other.tag == "y+") {
			if (bounce == false) {
				mirror.transform.localScale = new Vector2 (mirrorX, 1);
			} else {
				mirror.transform.localScale = new Vector2 (mirrorX, -1);
			}
		}
		if (other.tag == "y-") {			
			if (bounce == false) {
				mirror.transform.localScale = new Vector2 (mirrorX, 1);
			} else {
				mirror.transform.localScale = new Vector2 (mirrorX, -1);
			}
		}*/
		if (other.tag == "brick") {
			Destroy (other.gameObject,Time.deltaTime);
		}
		/*if (other.tag == "brick") {
	
			float distX = Mathf.Abs (other.transform.position.x - transform.position.x);
			float distY = Mathf.Abs (other.transform.position.y - transform.position.y);
			float mePosX = transform.position.x;
			float mePosY = transform.position.y;
			float hePosX = other.transform.position.x;
			float hePosY = other.transform.position.y;

			if (distX > distY) {
				if (mePosX > hePosX) {
					//Bola ta na direita
					mirror.transform.localScale=new Vector2(-1,1);
				} else {
					//Bola ta na esquerda
					mirror.transform.localScale=new Vector2(1,1);
				}
			} else {
				if (mePosY > hePosY) {
					//Bola ta em cima
					mirror.transform.localScale=new Vector2(1,1);
				} else {
					//Bola ta em baixo
					mirror.transform.localScale=new Vector2(1,1);
				}
			}
			Destroy (other.gameObject);
		}*/
	}

	void OnCollisionEnter2D(Collision2D coll) {
	//Detectar as bordas
		/*if (coll.gameObject.tag == "x") {
			bounceX ();
		}
		if (coll.gameObject.tag == "y") {
			bounceY ();
		}*/
	//Detectar os bricks
		if (coll.gameObject.tag == "brick") {
			Destroy (coll.gameObject,Time.deltaTime);
		}
	//Detectar o mouse
		if (coll.gameObject.tag == "bouncer") {
			mouseCos = Mathf.Cos (coll.gameObject.transform.eulerAngles.z) * speed;
			mouseSin = Mathf.Sin (coll.gameObject.transform.eulerAngles.z) * speed;
			rb.velocity = new Vector2 (mouseCos, mouseSin);

			bounce = true;
			bouncer ();
		}
	}


//Referente ao mouse
	public void bouncer(){
		stop ();
		levelManager.GetComponent<LevelScript> ().Ballspeed = 7f;
		/*if (transform.position.x > bouncerSon.transform.position.x) {
			mirror.transform.localScale = new Vector2 (-1, 1);
		} else {
			mirror.transform.localScale = new Vector2 (1, 1);
		}
		spiner.transform.localEulerAngles= new Vector3 (0, 0, bouncerSon.transform.eulerAngles.z+45);*/
	}

	/*void bounceX(){
		mirror.transform.localScale = new Vector2 (mirror.transform.localScale.x * -1, mirror.transform.localScale.y);
		bounce = false;
	}

	void bounceY(){
		mirror.transform.localScale = new Vector2 (mirror.transform.localScale.x, mirror.transform.localScale.y * -1);
		bounce = false;
	}*/

	void stop(){
		Debug.Break ();
	}
}
