using UnityEngine;
using System.Collections;

public class MainMenuLevel2 : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width / 2 - 0, Screen.height / 3 - 15, 200, 30), "Load Level 2 (Hard)")) {
			Application.LoadLevel("Scene 2");
		}
	}
}
