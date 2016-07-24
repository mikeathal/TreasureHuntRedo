using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public class Treasure : MonoBehaviour {
	bool didPlayerWin = false ;
	bool WinDoorUnlocked = false;
	public Rigidbody2D PlayerSpeed;
	public SpriteRenderer PlayerSprite;

	public Transform PlayerPos;
	public SpriteRenderer PlayerColorInvert;

	public Text WinText;
	public Transform WinPos;

	bool MistyVisited = false;
	public Text MistyText;
	public SpriteRenderer Misty;
	public Transform MistyPos;

	bool SleepyVisited = false;
	public Text SleepyText;
	public SpriteRenderer Sleepy;
	public Transform SleepyPos;

	bool WideEyesVisited = false;
	public Text WideEyesText;
	public SpriteRenderer WideEyes;
	public Transform WideEyesPos;

	bool RainbowsVisited = false;
	public Text RainbowsText;
	public SpriteRenderer Rainbows;
	public Transform RainbowsPos;

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		
		// Checking if Player Won and has visited all rooms
		if ( (WinPos != null) && ((WinPos.position - PlayerPos.position).magnitude < 2.5f) && (Input.GetKeyDown (KeyCode.Space)) &&
			(WinDoorUnlocked = true) ) {

			Debug.Log ("#Winning");
			WinText.enabled = true;
			didPlayerWin = true;
		}
		if (didPlayerWin) {
			WinText.text = "Nice! You made it to Jenna's party!";
		}



		// Checking if player has visited a room
		if ( ((MistyPos.position-PlayerPos.position).magnitude < 2.5f) && (Input.GetKeyDown(KeyCode.Space)) ) {
			Debug.Log("Misty Ran");
			Misty.enabled = true;
			MistyText.text = "Yooooo what's uuuuuup dude! \nOh maaan Jenna's party? Umm... We know it's not like, in any of the 4 2 rOoms... we're having a LAN party with the dudes in those rooms hahaha \nBest of luck yo!";
			MistyVisited = true;
		}

		if ( ((SleepyPos.position-PlayerPos.position).magnitude < 2.5f) && (Input.GetKeyDown(KeyCode.Space)) ) {
			Debug.Log("Sleepy Ran");
			Sleepy.enabled = true;
			SleepyText.text = "Mmmmmggghhhhhhhh... huh? \n'Z puhrty mgggghhhhh 'z east mmmmgggghhhh.";
			SleepyVisited = true;

		}
		if ( ((WideEyesPos.position-PlayerPos.position).magnitude < 2.5f) && (Input.GetKeyDown(KeyCode.Space)) ) {
			Debug.Log ("WideEyes Ran");
			WideEyes.enabled = true;
			WideEyesText.text = "OMG HOW ARE YOU?!?! IT'S BEEEN SO LONG SINCE I'VE SEEEEEN YOU!! \nCOME GIMME A HUG!! WHAT?! JENNA'S PARTY?! \nIT'S IN AND EEEEEEEeeeeeEEEEEEEVEN DORM!! Sleepy Brett might know something in West Hall\nTAKE THIS TO GET THERE FAAASTER!!";
			WideEyesVisited = true;
			PlayerSpeed.drag = 20f ;

		}
		if ( ((RainbowsPos.position-PlayerPos.position).magnitude < 2.5f) && (Input.GetKeyDown(KeyCode.Space)) ) {
			Debug.Log ("Rainbows Ran");
			Rainbows.enabled = true;
			RainbowsText.text = "Shhh, quiet down--can you see the walls breathing? \nReality itself is so... colorful... I'm so feeling at one with the carpet right now. \nOh a party? All I can think about the room was the curls in the room number.";
			RainbowsVisited = true;
		}

		if ( (MistyVisited = true) && (SleepyVisited = true) && (WideEyesVisited = true) && (RainbowsVisited = true) ) {
			WinDoorUnlocked = true;
		}

	}
}
