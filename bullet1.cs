using UnityEngine;
using System.Collections;

public class bullet1 : MonoBehaviour {

	// Inspector Variables
	public float speed = 15.0f;
	public float lifespan = 0.35f;
	public Transform explosion;
	public Vector3 path;
	public GameObject oursceneManager;
	public AudioClip e1death;

	// Private Variables

	// Use this for initialization
	void Start () {
		Vector3 mousePos = Input.mousePosition;
		mousePos.Set (mousePos.x, mousePos.y, 15);
		path = Camera.main.ScreenToWorldPoint (mousePos);
		transform.LookAt (path);
	}
	
	// Update is called once per frame
	void Update () {
		// a real hack-y way to fix my problem
		if (transform.position.z != 2.7f) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, 2.7f);
		}
		transform.position += transform.forward * speed * Time.deltaTime;
		Destroy(gameObject, lifespan);
	}

	void OnTriggerEnter(Collider other) {
		// Check for the asteroid
		if (other.gameObject.tag == "enemy1") {
			// Create explosion on impact
			Instantiate (explosion, transform.position, transform.rotation);
			AudioSource.PlayClipAtPoint (e1death, transform.position);

			// Tell scene manager that we destroyed an enemy -> add score
			sceneManager scenem = oursceneManager.GetComponent<sceneManager>();
			sceneManager.numEnemies--;
			sceneManager.numKilled++;
			scenem.AddScore();

			Destroy (other.gameObject);


			// other.GetComponent("script name").variable etc
			//print (sceneManager.numEnemies);

			Destroy (gameObject);
		}
	}
}
