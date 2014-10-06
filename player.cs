using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	// Inspector Variables
	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;
	public Transform bullet1;
	public Transform socketBullet;
	public Transform socketThruster;
	public Transform thruster;
	public Transform explosion;
	public GameObject oursceneManager;
	public Transform enemy1;
	public Vector3 bullpath;



	// Private Variables 


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Move Player based on Input
		// Get the horizontal and vertical axis.
		// By default they are mapped to the arrow keys.
		// The value is in the range -1 to 1
		float translation  = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		// Activate thrusters
		float hVel = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
		float vVel = Input.GetAxisRaw("Vertical") * Time.deltaTime;
		if ((hVel != 0) || (vVel != 0)) {
			Instantiate(thruster, socketThruster.position, socketThruster.rotation);
		}
		
		// Make it move 10 meters per second instead of 10 meters per frame...
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		
		// Move translation along the object's z-axis
		transform.Translate (0, 0, translation);
		// Rotate around our y-axis
		transform.Rotate (0, rotation, 0);

		// Create a bullet
		if (Input.GetMouseButtonDown(0)) {
			bullpath = Input.mousePosition;
			socketBullet.rotation.SetLookRotation(bullpath, Vector3.up);
			Instantiate (bullet1, socketBullet.position, socketBullet.rotation);
			audio.Play ();
		}

	}

	void OnTriggerEnter(Collider other) {
		// Check for the asteroid
		if (other.gameObject.tag == "enemy1") {
			// Create explosion on impact
			Instantiate (explosion, transform.position, transform.rotation);
			sceneManager scenem = oursceneManager.GetComponent<sceneManager>();
			PlayerPrefs.SetInt("SCORE", scenem.GetScore());
			StartCoroutine(GameOver ("GameOver", 0.75f));
		}
	}
	

	IEnumerator GameOver(string level, float delay) {
		yield return new WaitForSeconds(delay);
		Application.LoadLevel("GameOver");
	}
}
