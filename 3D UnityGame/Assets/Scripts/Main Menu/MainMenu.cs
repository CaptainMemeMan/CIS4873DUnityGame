using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public GameObject CreditsPage;
    public GameObject TutorialPage;
    public GameObject MainMenuPage;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Tutorial()
    {
        TutorialPage.SetActive(true);
        MainMenuPage.SetActive(false);
    }
    public void BackTutorial()
    {
        TutorialPage.SetActive(false);
        MainMenuPage.SetActive(true);
    }
    public void PlayTutorial()
    {
        SceneManager.LoadScene(2);
    }
    public void Credits()
    {
        CreditsPage.SetActive(true);
        MainMenuPage.SetActive(false);
    }

    public void BackCredits()
    {
        CreditsPage.SetActive(false);
        MainMenuPage.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
