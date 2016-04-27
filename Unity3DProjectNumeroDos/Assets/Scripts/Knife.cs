using UnityEngine;
using System.Collections;

public class Knife : MonoBehaviour {

	public bool Look;
    public bool right;
	public float absVelX = 0f;
	public float absVelY = 0f;
	public bool standing;
	public float standingThreshold = 1;

	private Rigidbody body;

	void Awake(){
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
        Look = Input.GetKeyDown(KeyCode.RightArrow);
    }

	void FixedUpdate(){
		absVelX = System.Math.Abs (body.velocity.x);
		absVelY = System.Math.Abs (body.velocity.y);

		standing = absVelY <= standingThreshold;
	}
}
