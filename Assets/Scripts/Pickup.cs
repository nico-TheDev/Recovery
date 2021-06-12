using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    UIManager loader;
    // Start is called before the first frame update
    void Start()
    {
        loader = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            loader.ShowClearLevelPanel();
            other.gameObject.SetActive(false);
        }
    }
}
