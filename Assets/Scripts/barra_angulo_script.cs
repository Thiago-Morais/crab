using UnityEngine;
using System.Collections;

public class barra_angulo_script : MonoBehaviour {

	public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//	transform.LookAt (ball.transform.position);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, target.transform.rotation, 5);
	}
}
