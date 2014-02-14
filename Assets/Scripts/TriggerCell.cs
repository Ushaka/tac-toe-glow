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

		if (TicTacToe.playersTurn.Equals("player1") && TicTacToe.isFalling == false && TicTacToe.thereIsAWinner == false) {
			if (playerType.Equals ("-")) {
				TicTacToe.isFalling = true;
				playerType = "x";
				TicTacToe.counter += 1; 
				Instantiate(datX, fallPosition, Quaternion.identity);
				TicTacToe.isFalling = true; 
				TicTacToe.playersTurn = "player2"; 
				GameObject.Find ("playerText").GetComponent<TextMesh>().text = "Player: O"; 
				//TicTacToe.isFalling = true;
				//StartCoroutine(gamestate.WaitABit(3));
				//StartCoroutine(gamestate.WaitABit(3));
			} else {
				Debug.Log ("You cannot place here");
			}
			Debug.Log (playerType);
		//	gamestate.playerTurn = false;
		//	gamestate.aiTurn();
			}
		if (TicTacToe.playersTurn.Equals ("player2") && TicTacToe.isFalling == false && TicTacToe.thereIsAWinner == false) {
			if (playerType.Equals ("-")) {
				TicTacToe.isFalling = true;
				playerType = "o";
				TicTacToe.counter += 1; 
				Instantiate(datO, fallPosition, Quaternion.identity);
				GameObject.Find ("playerText").GetComponent<TextMesh>().text = "Player: X"; 
				TicTacToe.playersTurn = "player1"; 

			}
			else{
					Debug.Log ("You cannot place here"); 
				}
		}

	}
	

	public void aiDrop() {
		Instantiate(datO, fallPosition, Quaternion.identity);
		//gamestate.playerTurn = true;
	}

	/**
	 * Update cell state with correct player type 
	 */
	void OnCollisionStay(Collision other) {
		if(other.gameObject.tag.Equals("o")) {
			TicTacToe.isFalling = false;
		} else if(other.gameObject.tag.Equals("x")) {
			TicTacToe.isFalling = false;
		}

	}

}

