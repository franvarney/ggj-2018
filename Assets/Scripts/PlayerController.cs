using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : FlyingController {

    public float xySpeed = 1.5f;

    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.tag);
        if (other.gameObject.CompareTag("Obstacle")) {
            Restart();
        }else if (other.gameObject.CompareTag("Finish"))
        {
            isMoving = false;
            rigidBody.velocity = Vector3.zero;
        }
    }

    private void Restart() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    private void Update()
    {
        if (isMoving) {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
                rigidBody.MovePosition(transform.position + Vector3.up * xySpeed);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
                rigidBody.MovePosition(transform.position + Vector3.right * xySpeed);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
                rigidBody.MovePosition(transform.position + Vector3.down * xySpeed);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
                rigidBody.MovePosition(transform.position + Vector3.left * xySpeed);
            }
        }
    }
}
