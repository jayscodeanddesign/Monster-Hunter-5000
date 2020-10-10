using UnityEngine;
using System.Collections;

public class CreditsMenu : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(0,0,100,50), "Credits")) {
			Application.LoadLevel("Credits");
		}
	}
}