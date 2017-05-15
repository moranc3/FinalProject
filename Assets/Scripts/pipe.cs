using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour {

	Player player;
	public bool movePlayer = false;
	public GameObject destination;

	public void OnCollisionEnter2D (Collision2D coll)
	{
		if (Input.GetKeyDown (KeyCode.A)) {
			movePlayer = true;
			player.transform.position = destination.transform.position;
		}
	}

}

