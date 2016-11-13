using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 0.03f;

		if (gameObject.name == "RedBumper")
			transform.Translate (0, 0, Input.GetAxis ("Horizontal") * speed);
		else
			transform.Translate (0, 0, Input.GetAxis ("Vertical") * speed);
	}
}
