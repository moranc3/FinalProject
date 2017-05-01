using System.Collections;	
using UnityEngine;

	namespace AssemblyCSharp
{

	public class StunGrenade : Throwable {

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

					StartCoroutine(Stun (e));
				}
			}

			//set bomb to not active so it disappears and you cant pick it up again.
			collider2D.enabled = false;
			GetComponent<SpriteRenderer> ().enabled = false;
		}

	IEnumerator Stun(Enemy e)
	{
			var renderer = e.GetComponent<SpriteRenderer> ();

			e.enabled = false;
			renderer.color = new Color (1, 1, 1, .4f);
			yield return new WaitForSeconds (5);

			e.enabled = true;
			renderer.color = new Color (1, 1, 1, 1);
	}
}
}

