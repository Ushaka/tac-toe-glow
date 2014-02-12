using UnityEngine;
using System.Collections;

public class TriggerCell : MonoBehaviour {

	public TicTacToe gamestate;
	public string playerType;
	public Vector3 fallPosition;
	public GameObject datX;
	public GameObject datO;

	// Use this for initialization
	void Start () {
		gamestate = GameObject.Find ("GameState").GetComponent<TicTacToe> ();
		playerType = "-";
		fallPosition = this.gameObject.transform.position;
		fallPosition.y += 5;

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown() {

		if (gamestate.playerTurn && TicTacToe.isFalling == false) {
			if (playerType.Equals ("-")) {
				Debug.Log ("You can place here");
				Instantiate(datX, fallPosition, Quaternion.identity);
				TicTacToe.isFalling = true;
				StartCoroutine(gamestate.WaitABit(3));
				if(gamestate.findWinner().Equals("x")) {
					Debug.Log ("Player won!");
				}
				StartCoroutine(gamestate.WaitABit(3));
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
	

	public void aiDrop() {
		Instantiate(datO, fallPosition, Quaternion.identity);
		gamestate.playerTurn = true;
	}

	/**
	 * Update cell state with correct player type 
	 */
	void OnCollisionStay(Collision other) {

		if(other.gameObject.tag.Equals("o")) {
			TicTacToe.isFalling = false;
			playerType = "o";
		} else if(other.gameObject.tag.Equals("x")) {
			playerType = "x";
			TicTacToe.isFalling = false;

		}
	}
}
