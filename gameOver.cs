using UnityEngine;
using System.Collections;

// Game Over script
public class gameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		// Make a group on the center of the screen
		GUI.BeginGroup (new Rect ((Screen.width / 2) - 50, (Screen.height / 2) - 50,
		                          100, 175));
		// Make a box to see the group on screen
		GUI.Box (new Rect (0, 0, 100, 175), "Game Over");

		GUI.Box (new Rect (0, 30, 100, 50), "Score: " + PlayerPrefs.GetInt ("SCORE"));
		
		// Add buttons for game navigation
		if (GUI.Button (new Rect (10, 60, 80, 30), "Try Again")) {
			Application.LoadLevel("Game_Scene");
		}
		
		// Add buttons for game navigation
		if (GUI.Button (new Rect (10, 95, 80, 30), "Quit")) {
			Application.Quit ();
		}
		
		GUI.EndGroup ();
	}
}
