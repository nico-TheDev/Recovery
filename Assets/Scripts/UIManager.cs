using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject deathPanel;
    public GameObject clearLevelPanel;

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
}
