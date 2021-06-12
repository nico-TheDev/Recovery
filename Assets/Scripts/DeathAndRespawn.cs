using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAndRespawn : MonoBehaviour
{

    UIManager loader;

    void Start()
    {
        loader = FindObjectOfType<UIManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("Collided with enemy or death");
        print(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
            loader.ShowDeathPanel();

        }

    }
}
