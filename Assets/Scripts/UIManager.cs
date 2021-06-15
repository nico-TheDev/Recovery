using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class UIManager : MonoBehaviour
{

    public GameObject deathPanel;
    public GameObject clearLevelPanel;

    public GameObject pauseBtn;

    public GameObject nextLevelBtn;
    public GameObject endBtn;


    public TextMeshProUGUI deathCounter;

    public void HideNextLevelBtn()
    {
        nextLevelBtn.SetActive(false);
    }

    public void ShowEndBtn()
    {
        endBtn.SetActive(true);

    }

    public void HidePauseBtn()
    {
        pauseBtn.SetActive(false);
    }

    public void ShowDeathPanel()
    {
        deathPanel.SetActive(true);
    }
    public void HideDeathPanel()
    {
        deathPanel.SetActive(false);
    }

    public void ShowClearLevelPanel()
    {
        clearLevelPanel.SetActive(true);
    }
    public void HideClearLevelPanel()
    {
        clearLevelPanel.SetActive(false);
    }

    public void SetDeathCount(int count)
    {
        deathCounter.SetText("Death Count:" + count.ToString());
    }
}
