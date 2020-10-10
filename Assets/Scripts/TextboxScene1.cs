using UnityEngine;
using System.Collections;

public class TextboxScene1 : MonoBehaviour {
    void OnGUI() {
        GUI.Box(new Rect(0,Screen.height - 30,150,50), "Mission: Kill Evil Cube");
    }
}