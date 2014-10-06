using UnityEngine;
using System.Collections;

public class thruster : MonoBehaviour {

	// Inspector variables
	public float lifespan = 0.15f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, lifespan);
	}
}
