using UnityEngine;
using System.Collections;

public class DragonAI : MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	public int maxdistance;
	
	private Transform myTransform;
	
	
	void Awake() {
		myTransform = transform;
	}
	
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		
		target = go.transform;
	
		maxdistance = 2;
	}
	
	
	void Update () {
		Debug.DrawLine(target.transform.position, myTransform.position, Color.blue);
		
		//Look at Player
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position),rotationSpeed * Time.deltaTime);
		
		if(Vector3.Distance(target.position, myTransform.position) > maxdistance) {
			//Move towards Player
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		}
		
	
	}
}