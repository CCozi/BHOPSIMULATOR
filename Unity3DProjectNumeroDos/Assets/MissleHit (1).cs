using UnityEngine;
using System.Collections;

public class MissleHit : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("hit missle");

		Rigidbody2D otherBody = other.GetComponent<Rigidbody2D> ();
		otherBody.velocity = new Vector2 (-400, 200);
		}
}