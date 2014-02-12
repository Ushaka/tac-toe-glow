using UnityEngine;
using System.Collections;

public class TriggerCell : MonoBehaviour {

	public string playerType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	/**
	 * Update cell state with correct player type 
	 */
	void OnCollisionStay(Collider other) {

		if(other.gameObject.name.Equals("Circle")) {
			playerType = "o";
		} else if(other.gameObject.name.Equals("WholeX")) {
			playerType = "x";
		}
	}
}
