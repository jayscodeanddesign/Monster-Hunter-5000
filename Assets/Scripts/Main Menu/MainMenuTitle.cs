using UnityEngine;
using System.Collections;

public class MainMenuTitle : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 7 - 35, 300, 60), "Monster Hunter 5000")) {
			Application.LoadLevel("About");
		}
	}
}