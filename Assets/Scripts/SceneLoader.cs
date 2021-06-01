using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void ContinueGame()
    {
        SceneManager.LoadScene("TestScene");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
