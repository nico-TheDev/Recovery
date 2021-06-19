using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundPlayer : MonoBehaviour
{
    AudioManager audioManager;


    void Awake()
    {

    }
    void Start()
    {
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;

    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        audioManager = FindObjectOfType<AudioManager>();

        string sceneName = currentScene.name;
        audioManager.StopAll();



        if (sceneName == "MenuScene")
        {
            audioManager.Play("Menu");
        }
        else if (sceneName == "Level1" || sceneName == "Level2" || sceneName == "Level3")
        {
            audioManager.Play("firstStage");
        }
        else if (sceneName == "Level4" || sceneName == "Level5" || sceneName == "Level6")
        {
            audioManager.Play("secondStage");

        }
        else if (sceneName == "Level7" || sceneName == "Level8" || sceneName == "Level9" || sceneName == "Level10")
        {
            audioManager.Play("thirdStage");

        }
        else if (sceneName == "DialogueScene")
        {
            audioManager.Play("dialogue");
        }
    }

    public void PlayClick()
    {
        audioManager.Play("Click");
    }


}
