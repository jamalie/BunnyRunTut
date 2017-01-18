using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BimmyController : MonoBehaviour {

    private Rigidbody2D myRigidBody;
    private Animator myAnim;
    public float bunnyJumpForce = 500f;

	// Use this for initialization
    // This will look on the current game object and find the rigid2d component that is attached to it and assign it to the rigidbody variable
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Jump"))
        {
            myRigidBody.AddForce(transform.up * bunnyJumpForce);
        }
        myAnim.SetFloat("vVelocity", myRigidBody.velocity.y);
	}
}
