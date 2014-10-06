using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	// Inspector Variables
	public float lifespan = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, lifespan);
	}
}
