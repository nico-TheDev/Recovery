using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundPlayer : MonoBehaviour
{



    AudioManager audioManager;
    void Awake()
    {

    }
    void Start()
    {
        audioManager = gameObject.GetComponent<AudioManager>();
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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
