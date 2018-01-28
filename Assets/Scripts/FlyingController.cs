using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingController : MonoBehaviour {

    public float zSpeed = 5.0f;

    protected bool isMoving = false;
    protected bool isDead = false;
    protected bool isLevelFinished = false;
    
    protected Rigidbody rigidBody;

	void Awake() {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	protected void FixedUpdate() {
        if (isMoving && !isDead && !isLevelFinished) {
            rigidBody.AddForce(Vector3.forward * zSpeed);
        }
    }

    public void Move()
    {
        isMoving = true;
    }
}
