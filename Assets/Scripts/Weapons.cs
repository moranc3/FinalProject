﻿using System.Collections;
using UnityEngine;

public class Weapons : MonoBehaviour {

	protected new Rigidbody2D rigidbody2D;
	protected new Collider2D collider2D;

	void Start()
	{
		rigidbody2D = GetComponent<Rigidbody2D> ();
		collider2D = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public virtual void Attack ()
	{ 
		
	}

	public virtual void GetPickedUp (Player player)
	{
		Debug.Log ("Got picked up");
		transform.parent = player.transform;
		transform.localScale = new Vector3 (.7f, .7f);
		transform.localPosition = new Vector3 (.2f, .2f);
		rigidbody2D.isKinematic = true;
		rigidbody2D.velocity = new Vector2 ();
		collider2D.enabled = false;
		player.AddWeapon (this);
	}
}
