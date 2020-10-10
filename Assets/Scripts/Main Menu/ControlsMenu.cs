using UnityEngine;
using System.Collections;

public class ControlsMenu : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width - 100,0,100,50), "Controls")) {
			Application.LoadLevel("Controls");
		}
	}
}
