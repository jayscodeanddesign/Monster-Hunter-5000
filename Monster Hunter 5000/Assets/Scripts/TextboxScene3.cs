using UnityEngine;
using System.Collections;

public class TextboxScene3 : MonoBehaviour {
    void OnGUI() {
        GUI.Box(new Rect(0,Screen.height - 30,170,50), "Mission: Defeat the Alien!");
    }
}
