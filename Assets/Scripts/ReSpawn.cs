using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReSpawn : MonoBehaviour
{

	[SerializeField] private Image panel;

	public int fadeDuration;
	
	// Use this for initialization
	void Start ()
	{
		panel = GetComponent<Image>();
		Respawn();
	}

	public void Respawn()
	{
		FadeOut();
		Invoke("FadeIn", fadeDuration + 1);
	}
	
	private void FadeIn()
	{
		panel.CrossFadeAlpha(0f, fadeDuration, true);
	}


	private void FadeOut()
	{
		panel.CrossFadeAlpha(255f, fadeDuration,true );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
