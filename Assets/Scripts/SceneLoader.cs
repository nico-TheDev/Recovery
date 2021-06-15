using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    UIManager uiManager;
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();

        if (SceneManager.GetActiveScene().name == "Level10")
        {
            uiManager.HideNextLevelBtn();
        }
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void RestartScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }


    // LEVELS

    public void LoadLevel(string target)
    {
        SceneManager.LoadScene("Level" + target);
    }

    public void LoadNextLevel()
    {
        int nextLevel = PlayerPrefs.GetInt("CurrentPlayerLevel") + 1;
        SceneManager.LoadScene("Level" + nextLevel.ToString());
    }

    public void ClearDeathCount()
    {
        PlayerPrefs.SetInt("deathCount", 0);
    }
}
