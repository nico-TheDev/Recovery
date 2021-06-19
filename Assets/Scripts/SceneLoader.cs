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
            uiManager.ShowEndBtn();
        }
    }

    public void ClearSave()
    {
        PlayerPrefs.SetInt("deathCount", 0);
        PlayerPrefs.SetInt("CurrentPlayerLevel", 0);
        PlayerPrefs.SetInt("SaveData", 0);
    }

    public void ContinueGame()
    {
        int saveLevel = PlayerPrefs.GetInt("SaveData");
        print("current Save is " + saveLevel);
        if (saveLevel == 0)
        {
            LoadNewGame();
        }
        else
        {
            LoadLevel(saveLevel.ToString());
        }
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

    public void LoadNewGame()
    {
        ClearSave();

        LoadDialogue();
    }

    public void LoadDialogue()
    {
        SceneManager.LoadScene("DialogueScene");

    }


    // LEVELS

    public void LoadLevel(string target)
    {
        SceneManager.LoadScene("Level" + target);
        FindObjectOfType<AudioManager>().StopAll();
    }

    public void LoadNextLevel()
    {
        int nextLevel = PlayerPrefs.GetInt("CurrentPlayerLevel") + 1;
        SceneManager.LoadScene("Level" + nextLevel.ToString());
    }

    public void LoadFinal()
    {
        int nextLevel = PlayerPrefs.GetInt("CurrentPlayerLevel") + 1;
        if (nextLevel == 11)
        {
            LoadDialogue();
        }
    }
    public void LoadCurrentLevel()
    {
        int currentLevel = PlayerPrefs.GetInt("CurrentPlayerLevel");
        SceneManager.LoadScene("Level" + currentLevel.ToString());
    }


}
