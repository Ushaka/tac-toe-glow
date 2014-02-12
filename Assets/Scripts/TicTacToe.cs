using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TicTacToe : MonoBehaviour {

	private static TicTacToe instance = null;

	public static TicTacToe Instance
	{
		get
		{
			if (instance==null)
			{
				instance = new TicTacToe();
			}
			return instance;
		}
	}
	public string[,] cells;
	public static bool playerTurn;
	
	
	
	// Use this for initialization
	void Start () {
		// Initialize the map
		cells = new string[3,3];
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

		if(Input.GetKeyDown(KeyCode.Return)) {

			Debug.Log ("Cell1 is here: " + GameObject.Find ("Cell1").GetComponent<TriggerCell>().playerType);
			cells [0, 0] = GameObject.Find ("Cell1").GetComponent<TriggerCell> ().playerType;
			cells [0, 1] = GameObject.Find ("Cell2").GetComponent<TriggerCell> ().playerType;
			cells [0, 2] = GameObject.Find ("Cell3").GetComponent<TriggerCell> ().playerType;
			cells [1, 0] = GameObject.Find ("Cell4").GetComponent<TriggerCell> ().playerType;
			cells [1, 1] = GameObject.Find ("Cell5").GetComponent<TriggerCell> ().playerType;
			cells [1, 2] = GameObject.Find ("Cell6").GetComponent<TriggerCell> ().playerType;
			cells [2, 0] = GameObject.Find ("Cell7").GetComponent<TriggerCell> ().playerType;
			cells [2, 1] = GameObject.Find ("Cell8").GetComponent<TriggerCell> ().playerType;
			cells [2, 2] = GameObject.Find ("Cell9").GetComponent<TriggerCell> ().playerType;


			Debug.Log("User pressed enter");
			string winner = findWinner();
			Debug.Log ("The winner is: " + winner);
		}
	
	}
	
	public void aiTurn() {

	}
	
	private string findWinner() {

		if(playerWon("o")) {
			return "o";

		} else if(playerWon("x")) {
			return "x";

		} else {
			Debug.Log ("Should be t");
			return "t";
		}

	}

	private bool playerWon(string player) {
		// check rows
		if (cells[0, 0] == player && cells[0, 1] == player && cells[0, 2] == player) { return true; }
		if (cells[1, 0] == player && cells[1, 1] == player && cells[1, 2] == player) { return true; }
		if (cells[2, 0] == player && cells[2, 1] == player && cells[2, 2] == player) { return true; }
		
		// check columns
		if (cells[0, 0] == player && cells[1, 0] == player && cells[2, 0] == player) { return true; }
		if (cells[0, 1] == player && cells[1, 1] == player && cells[2, 1] == player) { return true; }
		if (cells[0, 2] == player && cells[1, 2] == player && cells[2, 2] == player) { return true; }
		
		// check diags
		if (cells[0, 0] == player && cells[1, 1] == player && cells[2, 2] == player) { return true; }
		if (cells[0, 2] == player && cells[1, 1] == player && cells[2, 0] == player) { return true; }

		return false;

	}
}
