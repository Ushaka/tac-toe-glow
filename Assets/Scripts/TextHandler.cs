using UnityEngine;
using System.Collections;

public class TextHandler : MonoBehaviour {

	public bool dontShowAgain = false; 
	// Use this for initialization
	void Start () {
		GameObject.Find ("playerText").GetComponent<TextMesh>().text = ""; 
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayGame.gameStarted == true && dontShowAgain == false) {
			StartCoroutine(WaitABit(1.0f)); 
			dontShowAgain = true;
		}
	}
	
	IEnumerator WaitABit(float waitTime){
		yield return new WaitForSeconds(waitTime);
		GameObject.Find ("playerText").GetComponent<TextMesh>().text = "Player: X"; 
	}
}
