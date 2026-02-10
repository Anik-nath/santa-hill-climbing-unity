using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject pauseButton;

    private bool gamePaused = false;

    void Update()
    {
        Time.timeScale = gamePaused ? 0 : 1;
    }

    public void PauseGame()
    {
        gamePaused = true;
        pauseScreen.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        gamePaused = false;
        pauseScreen.SetActive(false);
        pauseButton.SetActive(true);
    }
}
