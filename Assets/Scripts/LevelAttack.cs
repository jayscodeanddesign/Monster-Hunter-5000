using UnityEngine;
using System.Collections;

public class LevelAttack : MonoBehaviour {
	public GameObject target;
	public float attacktimer;
	public float cooldown;
	// Use this for initialization
	void Start () {
		attacktimer = 0;
		cooldown = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(attacktimer > 0)
			attacktimer -= Time.deltaTime;
		
		if(attacktimer < 0)
			attacktimer = 0;
		
		if(attacktimer == 0) {
			Attack();
			attacktimer = cooldown;
		}
	}
	
	private void Attack() {
		float distance = Vector3.Distance(target.transform.position, transform.position);
		
		Vector3 dir = (target.transform.position - transform.position).normalized;
			
		float direction = Vector3.Dot(dir, transform.forward);
		
		Debug.Log(direction);
		
		if(distance<7f){
			if(direction > 0) {
				Playerhealth eh = (Playerhealth)target.GetComponent("Playerhealth");
				eh.AdjustCurrentHealth(-9);
			}
		}
	}
}