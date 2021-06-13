using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    Scene currentScene;
    string currentLevel;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        currentLevel = currentScene.name.Remove(0, 5);
        PlayerPrefs.SetInt("CurrentPlayerLevel", Int32.Parse(currentLevel));
    }


}
