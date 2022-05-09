using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject startMenuUI;
    public static bool paused;
    public AudioListener audioListener;

    void start()
    {
        paused = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !startMenuUI.activeSelf)
        {
            if (paused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }
    public void Quit()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Application.Quit();
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
        paused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        paused = true;
    }
}
