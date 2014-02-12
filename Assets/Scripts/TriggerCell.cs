using UnityEngine;
using System.Collections;

public class TriggerCell : MonoBehaviour {

	public TicTacToe gamestate;
	public string playerType;

	// Use this for initialization
	void Start () {
		gamestate = TicTacToe.Instance;
		playerType = "-";

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown() {

		if (gamestate.playerTurn) {
			if (playerType.Equals ("-")) {
				Debug.Log ("You can place here");
				Instantiate();
			} else {
				Debug.Log ("You cannot place here");
			}
			Debug.Log (playerType);
			gamestate.playerTurn = false;
			gamestate.aiTurn();
		} else {
			Debug.Log("Not players turn");
		}
	}

	/**
	 * Update cell state with correct player type 
	 */
	void OnCollisionStay(Collision other) {

		if(other.gameObject.name.Equals("Circle")) {
			playerType = "o";
		} else if(other.gameObject.name.Equals("WholeX")) {
			playerType = "x";
		}
	}
}
