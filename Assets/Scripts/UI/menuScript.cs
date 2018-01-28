using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

   // public Canvas quitMenu;
  //  public Canvas controlsMenu;
    public Button startText;
    public Button exitText;

    // Use this for initialization
    void Start()
    {
       // quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
      //  controlsMenu = controlsMenu.GetComponent<Canvas>();
      //  quitMenu.enabled = false;
      //  controlsMenu.enabled = false;
    }

    public void ExitPress()
    {
       // quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
       // controlsMenu.enabled = false;
    }
    public void ControlsPress()
    {
       // controlsMenu.enabled = true;
       // quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
    }
    public void NoPress()

    {
      //  controlsMenu.enabled = false;
      //  quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;

    }
    public void StartLevel()
    {
        SceneManager.LoadScene("FlyingScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
