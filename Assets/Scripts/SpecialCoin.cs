using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCoin : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D coll)
	{
		var player = coll.gameObject.GetComponent<Player>();
		if (player != null) {
			gameObject.SetActive(false);
			FindObjectOfType<GM>().SetPoints(FindObjectOfType<GM>().GetPoints() + 5);
		}
	}

}

