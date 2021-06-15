using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAndRespawn : MonoBehaviour
{

    UIManager loader;
    int currentLevel;
    string deathCount = "deathCount";
    void Start()
    {
        loader = FindObjectOfType<UIManager>();
        currentLevel = PlayerPrefs.GetInt("PlayerCurrentLevel");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);

            if (PlayerPrefs.GetInt(deathCount) == 0)
            {
                PlayerPrefs.SetInt(deathCount, 1);
            }
            else
            {
                PlayerPrefs.SetInt(deathCount, PlayerPrefs.GetInt(deathCount) + 1);

            }

            loader.SetDeathCount(PlayerPrefs.GetInt(deathCount));
            loader.HidePauseBtn();
            loader.ShowDeathPanel();

        }

    }
}
