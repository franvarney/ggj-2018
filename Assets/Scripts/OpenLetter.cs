using UnityEngine;
using UnityEngine.UI;

public class OpenLetter : MonoBehaviour
{
	public Sprite openedLetter;

	private Image[] images;
	
	// Use this for initialization
	void Start () {
		
	}

	private void OnEnable()
	{
		Invoke("openLetter", 1.5f);
	}

	private void openLetter()
	{
		images = GetComponentsInChildren<Image>();
		foreach (Image image in images)
		{
			image.sprite = openedLetter;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
