using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public BirdController bird;
    public KeyCode startKey = KeyCode.Return;
    public PlayerController player;

	void Start () {
        
	}
	
	void Update () {
		if (Input.anyKeyDown) {
            StartRound();
        }
	}

    void StartRound() {
        bird.Move();
        player.Move();
    }
}
