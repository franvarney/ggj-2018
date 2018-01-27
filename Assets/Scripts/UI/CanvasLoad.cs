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

	private void OnCollisionEnter(Collision collision)
	{
		ScenePick.SetActive(true);
		Time.timeScale = 0;

	}
}
