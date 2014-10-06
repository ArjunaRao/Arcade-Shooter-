using UnityEngine;
using System.Collections;

public class enemy1 : MonoBehaviour {

	// Inspector Variables
	public float speed = 6.0f;
	public Transform player;
	public Transform explosion;
	public AudioClip pdeath;

	// Private Variables

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("pref_Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		// currently, once an enemy is spwaned it will stupidly just move towards the player
		// this code needs to change DRASTICALLY in order to make for interesting and fun gameplay
		transform.LookAt (player.transform, Vector3.back);
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "player") {
			Instantiate (explosion,transform.position, transform.rotation);
			AudioSource.PlayClipAtPoint (pdeath, transform.position);


			// other.GetComponent("script name").variable etc

			//Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
