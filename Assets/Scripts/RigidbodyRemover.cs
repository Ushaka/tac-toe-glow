using UnityEngine;
using System.Collections;

public class RigidbodyRemover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayGame.gameStarted == true) {
			StartCoroutine(WaitABit(1.0f)); 
		}
	}

	IEnumerator WaitABit(float waitTime){
		yield return new WaitForSeconds(waitTime);
		Destroy(this.gameObject.rigidbody);

	}
}
