using UnityEngine;
using System.Collections;

public class Inspect : MonoBehaviour {

	public bool Look;
	public bool Off;
	private Animator anim;
	private Rigidbody body;

	void Awake(){
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator>();
		Look = Input.GetKeyDown(KeyCode.F);
		Off = Input.GetKeyDown(KeyCode.G);
		if(Look)
			anim.SetBool("Look", true);
 		else if (Off)
			anim.SetBool("Look", false);
			}

	void FixedUpdate(){
		}
}
