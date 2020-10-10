using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
    void OnGUI() {
        GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 3 - 15, 200, 30), "Controls:");
    }
}