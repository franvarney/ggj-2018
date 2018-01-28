using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{


	[SerializeField] private Button[] menuButtons;

	private const KeyCode LEFT_ARROW = KeyCode.LeftArrow;
	private const KeyCode RIGHT_ARROW = KeyCode.RightArrow;
	private const KeyCode UP_ARROW = KeyCode.UpArrow;
	private const KeyCode DOWN_ARROW = KeyCode.DownArrow;

	private bool noKeySelected = true;
	
	// Use this for initialization
	void Start ()
	{
		menuButtons = GetComponentsInChildren<Button>();
		menuButtons[0].Select();
		noKeySelected = false;
	}

	private void OnEnable()
	{
		menuButtons = GetComponentsInChildren<Button>();
		menuButtons[0].Select();
		noKeySelected = false;
	}

	private void OnDisable()
	{
		noKeySelected = true;
	}

	// Update is called once per frame
	void Update () {
		if (noKeySelected && (Input.GetKeyDown(UP_ARROW) || 
		    Input.GetKeyDown(DOWN_ARROW) ||
		    Input.GetKeyDown(LEFT_ARROW) ||
		    Input.GetKeyDown(RIGHT_ARROW)))
		{
			menuButtons[0].Select();
			noKeySelected = false;
		}

		if (Input.GetMouseButtonDown(0))
		{
			noKeySelected = true;
		}
	}
}
