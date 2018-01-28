using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingController : MonoBehaviour {

    public float zSpeed = 5.0f;

    protected bool isMoving = false;
    protected Rigidbody rigidBody;

	void Awake() {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	protected void FixedUpdate() {
        if (isMoving) {
            rigidBody.AddForce(Vector3.forward * zSpeed);
        }
    }

    public void Move()
    {
        Debug.Log("Setting isMoving to true");
        isMoving = true;
    }
}
