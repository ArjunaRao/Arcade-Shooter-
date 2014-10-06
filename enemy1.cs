using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public Transform target;
	public float distance;
	public float lockedX = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// currently, once an enemy is spwaned it will stupidly just move towards the player
		// this code needs to change DRASTICALLY in order to make for interesting and fun gameplay
		transform.position = new Vector3 (target.transform.position.x, target.transform.position.y,
		                                  target.transform.position.z -distance);
	}
}
