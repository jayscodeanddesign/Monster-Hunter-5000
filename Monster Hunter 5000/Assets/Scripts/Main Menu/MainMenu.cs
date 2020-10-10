using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 3 - 15, 200, 30), "Load Level 1 (Normal)")) {
			Application.LoadLevel("Scene 1");
		}
	}
}