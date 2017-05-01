using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : Throwable {

	public float blastRadius = 5;

	void OnCollisionEnter2D(Collision2D coll)
	{
		var player = coll.gameObject.GetComponent<Player>();
		if(isActive && player == null) {
			Explode();
		}
	}
		

	public void Explode()
	{
		//get reference to all enemies
		var enemies = FindObjectsOfType<Enemy> ();

		// loop through each enemy in the list
		foreach (var e in enemies) {
			
			//check if that enemy is within the blast radius
			if (Vector3.Distance (this.transform.position, e.transform.position) < blastRadius) {
				e.gameObject.SetActive (false);
			}
		}
	
		//set bomb to not active so it disappears and you cant pick it up again.
		gameObject.SetActive (false);
	}
}