//3D Game
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject CrossHair;
    public GameObject player;



    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {   
        pauseMenuUI.SetActive(false);
        CrossHair.SetActive(true);
        Time.timeScale = 1f;
        player.SetActive(true);
        GameIsPaused = false;

    }

    public void Pause()
    {

        pauseMenuUI.SetActive(true);
        CrossHair.SetActive(false);
        Time.timeScale = 0f;
        player.SetActive(false);
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
