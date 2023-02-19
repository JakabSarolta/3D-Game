using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    private float jumpSpeed = 8;
    private Rigidbody rigidBody;
    private bool onGround = true;
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	void Update () {
        if (Input.GetKeyDown("space") && onGround)
        {
            rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            onGround = false;
        }
	}
    void OnCollisionEnter(Collision collision)
    { onGround = true;
    }
}
