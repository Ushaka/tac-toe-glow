using UnityEngine;
using System.Collections;

public class QuitScript : MonoBehaviour
{
	public static bool gameStarted = false;
	
	void OnMouseDown ()
	{
		Application.Quit ();
			
	}
}

