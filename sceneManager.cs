using UnityEngine;
using System.Collections;

// Scene Manager Script
public class sceneManager : MonoBehaviour {

	// Inspector Variables
	public static int score = 0;
	public static int multiplier = 1;
	public static int numEnemies = 0;
	public static int numKilled = 0;
	public static int multikills = 1;
	public int diffCoeff = 4; // number of enemies before spawn
	public int diffMult = 1; // to scale the difficulty

	public Transform enemy1;

	// Private Variables

	// Use this for initialization
	void Start () {
		score = 0;
		multiplier = 1;
		numEnemies = 0;
		numKilled = 0;
		multikills = 1;
	}
	
	// Update is called once per frame
	void Update () {
		// Spawn enemies
		if (numEnemies < diffCoeff * diffMult) {
			SpawnEnemies();
		}

		if (numKilled == multikills * multiplier) {
			multiplier++;
			multikills += numKilled;
			// miltplier : 1, 2, 3,  4,   5,
			// multikills: 1, 2, 6, 24, 120,
		}

	}

	public void AddScore() {
		score += (10 * multiplier);
	}

	public int GetScore() {
		return score;
	}

	void OnGUI() {
		// display the score
		GUI.Label (new Rect (600, 10, 100, 20), score.ToString());
		// display the multiplier
		GUI.Label (new Rect (500, 10, 100, 20), multiplier.ToString () + "x");
	}

	public void SpawnEnemies() {
		for (int i = numEnemies; i < (diffCoeff * diffMult); i++) {

		}
		int x = 0;
		while (x < 10) {
			Vector3 ppos = transform.position;
			Vector3 spos = new Vector3(0, 0, 0);
			spos.Set(ppos.x + x + 5, ppos.y + x, ppos.z);
			GameObject newEn;
			newEn = Instantiate (enemy1, spos, transform.rotation) as GameObject;
			numEnemies++;
			x++;
		}
	}
}
