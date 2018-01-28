using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasLoad : MonoBehaviour

{
	public GameObject ScenePick;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider collider)
	{
		if (!collider.CompareTag("Player")){return;}
		Debug.Log("ScenePick is active");
		ScenePick.SetActive(true);
	}
}
