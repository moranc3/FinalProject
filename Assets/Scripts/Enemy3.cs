using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour {

	Player player;
	public bool changeSpeed = false;
	public float speed = 5;
	public float lastforSeconds = 10;
	float timeStarted = 0;

	// Use this for initialization
	void Start () {
		player.speed = 5;
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (!enabled) {
			return;
		}
		var player = coll.gameObject.GetComponent<Player> ();
		if (player != null) {
			player.speed *= .5f;
			StartCoroutine (Slow (player));
		} 

	}
	IEnumerator Slow (Player player)
	{
		yield return new WaitForSeconds (10);
		player.speed /= .5f;
	}
}
