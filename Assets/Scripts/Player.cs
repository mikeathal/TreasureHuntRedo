using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public AudioSource PlayerKnocking;

	float LastTimeKnocked = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2 (0f, 0f);


		if (Input.GetKey (KeyCode.W)) {

			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, 300f) * Time.deltaTime;

		}


		if (Input.GetKey (KeyCode.S)) {

			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, -300f) * Time.deltaTime;

		}


		if (Input.GetKey (KeyCode.A)) {

			GetComponent<Rigidbody2D> ().velocity += new Vector2 (-300f, 0f) * Time.deltaTime;

		}

		if (Input.GetKey (KeyCode.D)) {

			GetComponent<Rigidbody2D> ().velocity += new Vector2 (300f, 0f) * Time.deltaTime;

		}
			
		if (Input.GetKeyDown (KeyCode.Space) && Time.time - LastTimeKnocked > 1f) {
			PlayerKnocking.PlayOneShot (PlayerKnocking.clip);
			LastTimeKnocked = Time.time;
		}

	}
}
