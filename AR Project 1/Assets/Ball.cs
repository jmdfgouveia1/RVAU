using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
	public Rigidbody rb;
	public bool started;
	public Text countText;

	private float sx;
	private float sy;

	private Vector3 startPos;
	private Quaternion startRot;
	private int redScore;
	private int blueScore;

	// Use this for initialization
	void Start () {
		redScore = 0;
		blueScore = 0;

	}

	void Reset() {
		transform.position = startPos;
		transform.rotation = startRot;
		GameReset ();
	}

	void UpdateText() {
		countText.text = "Blue " + blueScore.ToString() + " - " + redScore.ToString() + " Red";
	}

	void GameReset() {
		startPos = transform.position;
		startRot = transform.rotation;
		sx = Random.Range (0, 2) == 0 ? -1 : 1;
		sy = Random.Range (0, 2) == 0 ? -1 : 1;
		rb.velocity = new Vector3 (Random.Range (1, 1.5f) * sx, Random.Range (1, 1.5f) * sy, 0);
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "RedWall") {
			Debug.Log ("BLUE SCORED");
			Reset();
			blueScore++;
			UpdateText ();
		} else if (col.gameObject.name == "BlueWall") {
			Debug.Log ("RED SCORED");
			Reset();
			redScore++;
			UpdateText ();
		}
	}

	// Update is called once per frame
	void Update () {
		if (started) {
			Vector3 pos = transform.position;
			pos.y = 0.2f;
			transform.position = pos;
		}
			
		if (!started && Input.GetKeyDown ("space")) {
			GameReset ();
			started = false;
		}

	}
}
