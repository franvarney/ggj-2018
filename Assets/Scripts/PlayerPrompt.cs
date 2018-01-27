using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPrompt : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	public void Brazil()
	{
		SceneManager.LoadScene("Brazil");
		Time.timeScale = 1;

	}


	public void France()
	{
		SceneManager.LoadScene("France");
		Time.timeScale = 1;

	}

	public void Egypt()
	{
		SceneManager.LoadScene("Egypt");
		Time.timeScale = 1;

	}


	public void Japan()
	{
		SceneManager.LoadScene("Japan");
		Time.timeScale = 1;

	}

	public void Australia()
	{
		SceneManager.LoadScene("Australia");
		Time.timeScale = 1;

	}


	public void Antarctica()
	{
		SceneManager.LoadScene("Antarctica");
		Time.timeScale = 1;

	}

	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");
		Time.timeScale = 1;

	}




	// Update is called once per frame
	void Update () {

	}
}