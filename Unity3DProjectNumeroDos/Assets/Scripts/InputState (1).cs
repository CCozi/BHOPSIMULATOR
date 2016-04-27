using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {

	public bool Inspect;
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
		Inspect = Input.GetKeyDown(KeyCode.Space);
        Inspect = Input.GetKeyDown(KeyCode.RightArrow);
    }

	void FixedUpdate(){
		absVelX = System.Math.Abs (body.velocity.x);
		absVelY = System.Math.Abs (body.velocity.y);

		standing = absVelY <= standingThreshold;
	}
}
