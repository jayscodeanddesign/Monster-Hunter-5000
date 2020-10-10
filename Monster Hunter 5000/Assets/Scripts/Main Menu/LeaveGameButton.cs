using UnityEngine;
using System.Collections;

public class LeaveGameButton : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width / 2 - 0, Screen.height / 2 - 15, 200, 30), "Leave Game?")) {
			Application.Quit();
		}
	}
}
