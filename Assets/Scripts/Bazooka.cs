﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : Weapons {

	public GameObject rocketPrefab;

	public override void Attack ()
	{
		var rocket = Instantiate (rocketPrefab);
		rocket.transform.position = this.transform.position;
		rocket.GetComponent<Rigidbody2D> ().velocity = new Vector2 (10, 0-.5f);
		base.Attack ();
	}

}