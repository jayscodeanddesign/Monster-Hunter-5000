using UnityEngine;
using System.Collections;

public class TextboxScene2 : MonoBehaviour {
    void OnGUI() {
        GUI.Box(new Rect(0,Screen.height - 30,170,50), "Mission: Slay the Dragon!");
    }
}
