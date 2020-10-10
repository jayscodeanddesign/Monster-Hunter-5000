using UnityEngine;
using System.Collections;

public class LeaveGame : MonoBehaviour {
    void Update() {
        if (Input.GetKey("escape"))
            Application.Quit();
        
    }
}