using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SetVolume : MonoBehaviour
{
    public Toggle toggle;

    void Start()
    {
        if (PlayerPrefs.GetInt("isMuted") != 1)
        {
            toggle.isOn = false;

        }
        else
        {
            toggle.isOn = true;

        }
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
        //MANAGE SOUND
        if (PlayerPrefs.GetInt("isMuted") != 1)
        {
            toggle.isOn = false;

        }
        else
        {
            toggle.isOn = true;

        }

    }

    public void ManageSounds()
    {
        if (!toggle.isOn)
        {

            AudioListener.volume = 0;
            PlayerPrefs.SetInt("isMuted", 0);
        }
        else
        {
            AudioListener.volume = 1;
            PlayerPrefs.SetInt("isMuted", 1);
        }
    }
}
