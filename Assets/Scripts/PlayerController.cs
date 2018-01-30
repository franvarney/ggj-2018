using UnityEngine;

public class PlayerController : FlyingController {

    public float xySpeed = 1.5f;
    public float maxYPos;
    public float minYPos;
    public GameObject RespawnPanel;
    private Vector3 startPosition;
    
    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.tag);
        if (other.gameObject.CompareTag("Obstacle"))
        {
            isDead = true;
            Restart();
        }else if (other.gameObject.CompareTag("Finish"))
        {
            isMoving = false;
            isLevelFinished = true;
            rigidBody.velocity = Vector3.zero;
        }
    }

    private void Restart()
    {
        RespawnPanel.GetComponent<ReSpawn>().Respawn();
        rigidBody.velocity = Vector3.zero;
        isMoving = false;
        Invoke("homePosition", 3.5f);
    }

    private void homePosition()
    {
        gameObject.transform.position = startPosition;
        isDead = false;
        isLevelFinished = false;
    }

    private void Start()
    {
        
        startPosition = gameObject.transform.position;
    }

    private void Update()
    {
        if (isMoving && !isDead && !isLevelFinished) {
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

        checkBounds();
    }

    private void checkBounds()
    {
        if (rigidBody.position.y > maxYPos)
        {
            rigidBody.position = new Vector3(rigidBody.position.x, maxYPos, rigidBody.position.z);
        }else if (rigidBody.position.y < minYPos)
        {
            rigidBody.position = new Vector3(rigidBody.position.x, minYPos, rigidBody.position.z);
        }
    }
}
