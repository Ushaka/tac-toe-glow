using UnityEngine;
using System.Collections;

public class PlayGame : MonoBehaviour
{
		public bool gameStarted = false;

		void OnMouseUp ()
		{
				if (gameStarted == false) {
						GameObject.Find ("Board").GetComponent<Rigidbody> ().useGravity = true;
						Destroy(this.gameObject);
						gameStarted = true;
				
				}

		}
}
