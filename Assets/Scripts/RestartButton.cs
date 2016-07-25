using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		// Press R to restart the current scene
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene (0);

		}
	}
}
