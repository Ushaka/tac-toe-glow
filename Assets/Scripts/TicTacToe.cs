using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TicTacToe : MonoBehaviour {
	
	public TriggerCell[,] cells;
	public bool playerTurn;
	public static bool isFalling; 

	// Use this for initialization
	void Start () {
		// Initialize the map
		isFalling = false;
		playerTurn = true;
		cells = new TriggerCell[3,3];
//		int counter = 1;
//		for (int i = 0; i < 3; i++) {
//			for (int j = 0; j < 3; j++) {
//				Debug.Log ("Cell" + counter);
//				GameObject cell = GameObject.Find ("Cell" + counter);
//				Debug.Log (cell);
//				string playerType = cell.GetComponent<TriggerCell> ().playerType;
//				cells[i,j] = playerType;
//				counter++;
//			}
//		}
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (isFalling);
		cells [0, 0] = GameObject.Find ("Cell1").GetComponent<TriggerCell> ();
		cells [0, 1] = GameObject.Find ("Cell2").GetComponent<TriggerCell> ();
		cells [0, 2] = GameObject.Find ("Cell3").GetComponent<TriggerCell> ();
		cells [1, 0] = GameObject.Find ("Cell4").GetComponent<TriggerCell> ();
		cells [1, 1] = GameObject.Find ("Cell5").GetComponent<TriggerCell> ();
		cells [1, 2] = GameObject.Find ("Cell6").GetComponent<TriggerCell> ();
		cells [2, 0] = GameObject.Find ("Cell7").GetComponent<TriggerCell> ();
		cells [2, 1] = GameObject.Find ("Cell8").GetComponent<TriggerCell> ();
		cells [2, 2] = GameObject.Find ("Cell9").GetComponent<TriggerCell> ();

		
		if(Input.GetKeyDown(KeyCode.Return)) {



			Debug.Log("User pressed enter");
			string winner = findWinner();
			Debug.Log ("The winner is: " + winner);
		}
	
	}
	
	public void aiTurn() {

		while (true) { 
			if(isFalling == true){
			System.Random rnd = new System.Random();
			int i = rnd.Next(0,3);
			int j = rnd.Next(0,3);

			if(cells[i,j].playerType.Equals("-")) {
				StartCoroutine(WaitABit (5.0f));
				cells[i,j].aiDrop();
					isFalling = true; 
				if(findWinner().Equals("o")) {
					Debug.Log("AI won!");
				}
				break;
			}
		}
		}
		
	}
	
	public string findWinner() {

		if(playerWon("o")) {
			return "o";

		} else if(playerWon("x")) {
			return "x";

		}
		return "resume";

	}

	private bool playerWon(string player) {
		// check rows
		if (cells[0, 0].playerType == player && cells[0, 1].playerType == player && cells[0, 2].playerType == player) { return true; }
		if (cells[1, 0].playerType == player && cells[1, 1].playerType == player && cells[1, 2].playerType == player) { return true; }
		if (cells[2, 0].playerType == player && cells[2, 1].playerType == player && cells[2, 2].playerType == player) { return true; }
		
		// check columns
		if (cells[0, 0].playerType == player && cells[1, 0].playerType == player && cells[2, 0].playerType == player) { return true; }
		if (cells[0, 1].playerType == player && cells[1, 1].playerType == player && cells[2, 1].playerType == player) { return true; }
		if (cells[0, 2].playerType == player && cells[1, 2].playerType == player && cells[2, 2].playerType == player) { return true; }
		
		// check diags
		if (cells[0, 0].playerType == player && cells[1, 1].playerType == player && cells[2, 2].playerType == player) { return true; }
		if (cells[0, 2].playerType == player && cells[1, 1].playerType == player && cells[2, 0].playerType == player) { return true; }

		return false;

	}

	public IEnumerator WaitABit(float waitTime) {
		yield return new WaitForSeconds(waitTime);
	}
	
	
}
