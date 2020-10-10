using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width - 100,0,100,50), "Back to Menu")) {
			Application.LoadLevel("Main Menu");
		}
	}
}