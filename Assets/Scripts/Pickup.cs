using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    UIManager loader;
    // Start is called before the first frame update
    // public AnimationCurve myCurve;
    int nextLevel;
    void Start()
    {
        loader = FindObjectOfType<UIManager>();
        nextLevel = PlayerPrefs.GetInt("PlayerCurrentLevel") + 1;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            loader.ShowClearLevelPanel();
            loader.HidePauseBtn();
            other.gameObject.SetActive(false); // Deact Player
        }
    }
}
