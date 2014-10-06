using UnityEngine;
using System.Collections;

// Main Menu script
public class mainMenu : MonoBehaviour {

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
		GUI.Box (new Rect (0, 0, 100, 175), "shooter.virus");

		// Add buttons for game navigation
		if (GUI.Button (new Rect (10, 30, 80, 30), "Play")) {
			Application.LoadLevel("Game_Scene");
		}

		// Add buttons for game navigation
		if (GUI.Button (new Rect (10, 65, 80, 30), "Quit")) {
			Application.Quit ();
		}

		GUI.EndGroup ();
	}
}
