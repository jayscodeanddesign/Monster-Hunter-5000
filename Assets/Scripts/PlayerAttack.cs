using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
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
		
		if(Input.GetKeyUp(KeyCode.H)) {
			if(attacktimer == 0) {
				Attack();
				attacktimer = cooldown;
			}
		}
	}
	
	private void Attack() {
		float distance = Vector3.Distance(target.transform.position, transform.position);
		
		Vector3 dir = (target.transform.position - transform.position).normalized;
			
		float direction = Vector3.Dot(dir, transform.forward);
		
		Debug.Log(direction);
		
		if(distance<2.3f){
			if(direction > 0) {
				Enemyhealth eh = (Enemyhealth)target.GetComponent("Enemyhealth");
				eh.AdjustCurrentHealth(-10);
			}
		}
	}
}
