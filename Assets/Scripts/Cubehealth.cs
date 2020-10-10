using UnityEngine;
using System.Collections;

public class Cubehealth : MonoBehaviour {
	public int maxhealth = 100;
	public int curhealth = 100;
	
	public float healthBarLength;
	
	// Use this for initialization
	void Start () {
		healthBarLength = Screen.width / 3;
	}
	
	// Update is called once per frame
	void Update () {
	AdjustCurrentHealth(0);
	}
	
	void OnGUI() {
		GUI.Box(new Rect(10, 70, healthBarLength,20), curhealth + "/" + maxhealth);
	}
	
	public void AdjustCurrentHealth(int adj) {
		curhealth += adj;
		
		if(curhealth < 0)
			curhealth = 0;
		
		if(curhealth > maxhealth)
			curhealth = maxhealth;
		
		if(maxhealth < 1)
			maxhealth = 1;
		
    	if(curhealth < 1) { Destroy(gameObject); }
		
		healthBarLength = (Screen.width / 3) * (curhealth / (float)maxhealth);
		}
	}