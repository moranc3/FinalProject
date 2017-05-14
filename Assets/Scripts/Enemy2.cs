using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy {

	Player player;
	public bool killPlayer = false;


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (!enabled) {
			return;
		}
		var player = coll.gameObject.GetComponent<Player>();
		if(player != null) {
			player.GetOut ();
			player.GetOut ();
	}
}
}