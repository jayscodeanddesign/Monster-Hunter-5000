using UnityEngine;
using System.Collections;

public class MainMenuLevel3 : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 15, 200, 30), "Load Level 3 (Insane)")) {
			Application.LoadLevel("Scene 3");
		}
	}
}


