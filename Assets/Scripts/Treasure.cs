using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public class Treasure : MonoBehaviour {
	bool didPlayerWin = false ;
	public Text WinText;
	public Transform WinPos;
	public Text MistyText ;
	public Text SleepyText ;
	public Text WideEyesText ;
	public Text RainbowsText ;
	// Use this for initialization

	// Update is called once per frame
	void Update () {

		if ((WinPos.position - transform.position).magnitude < 2f) {
			
			if (Input.GetKeyDown (KeyCode.Space)) {
				didPlayerWin = true;
			}


		}
		if (didPlayerWin) {
			WinText.text = "Nice! You made it to Jenna's party!";

		}
		if (WinPos.position.y < -36.2721f) {
			MistyText.text = "Yooooo what's uuuuuup dude! \nOh maaan Jenna's party? Umm... \nWe know it's not like, in any of the \n4 2 rOoms... we're having a LAN party with the dudes in those rooms hahaha \nBest of luck yo!";

		}
		if (WinPos.position.x < -34f) {
			SleepyText.text = "Mmmmmggghhhhhhhh... huh? \n'Z puhrty mgggghhhhh 'z east mmmmgggghhhh.";

		}
		if (WinPos.position.y > 37.373f) {
			WideEyesText.text = "OMG HOW ARE YOU?!!?! IT'S BEEEEEEEN SO LONG SINCE I'VE SEEEEEEEN YOU!! \nCOME GIMME A HUG!! WHAT?! PARTY?! \nALL I REMEMBER IS IT'S IN AND EEEEEEEeeeeeEEEEEEEVEN DORM!!";

		}
		if (WinPos.position.x > 36.647f) {
			RainbowsText.text = "Shhh, quiet down--can you see the walls breathing? \nReality itself is so...colorful...I'm so feeling at one with the carpet right now. \nOh a party? All I can think about the room was the curls in the room number.";

		}

	}
}
