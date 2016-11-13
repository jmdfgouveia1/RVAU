using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Rigidbody rb;
	public bool up;

	float sx;
	float sy;


	// Use this for initialization
	void Start () {
		sx = Random.Range (0, 2) == 0 ? -1 : 1;
		sy = Random.Range (0, 2) == 0 ? -1 : 1;
	}

	// Update is called once per frame
	void Update () {
		if (up && Input.GetKeyDown ("space")) {
			up = false;
			rb.velocity = new Vector3 (Random.Range (1, 4) * sx, Random.Range (1, 4) * sy, 0);
		}
		//if (Input.GetKeyUp ("space"))
		//	up = true;



	}
}
