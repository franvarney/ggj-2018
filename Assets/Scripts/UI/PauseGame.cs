using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public Transform canvas;
    public Transform Player;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Pause();
        }
    }
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            //Player.GetComponent<TopDownController>().enabled = false;

        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
          //  Player.GetComponent<TopDownController>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;

        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;

    }

    public void OpenControls()
    {


    }

    public void RetryLevel1v1test()
    {
        SceneManager.LoadScene("1v1 Test");
        Time.timeScale = 1;

    }

    public void ExitLevel()
    {
        SceneManager.LoadScene("OverworldTest");
        Time.timeScale = 1;

    }

    public void Retry2Player()
    {
        SceneManager.LoadScene("2Player");
        Time.timeScale = 1;

    }

    public void Retry2PlayerRoulette()
    {
        SceneManager.LoadScene("2PlayerRoulette");
        Time.timeScale = 1;

    }

    public void Retry1PlayerRoulette()
    {
        SceneManager.LoadScene("1PlayerRoulette");
        Time.timeScale = 1;

    }

    public void Retry2PlayerSlots()
    {
        SceneManager.LoadScene("2PlayerSlots");
        Time.timeScale = 1;

    }

    public void Retry1PlayerSlots()
    {
        SceneManager.LoadScene("1PlayerSlots");
        Time.timeScale = 1;

    }


}