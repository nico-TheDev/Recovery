using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Click : MonoBehaviour
{

    public GameObject continueBtn;
    public void PlayClick()
    {
        FindObjectOfType<AudioManager>().Play("Click");
    }

    void Start()
    {

        if (SceneManager.GetActiveScene().name == "MenuScene")
        {
            Button btn = continueBtn.GetComponent<Button>();

            if (PlayerPrefs.GetInt("SaveData") == 0)
            {
                btn.interactable = false;
            }
            else
            {
                btn.interactable = true;
            }
        }

    }
}
