using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAndRespawn : MonoBehaviour
{
    // Start is called before the first frame update
    string currentScene;
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        currentScene = scene.name;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("Collided with enemy or death");
        print(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}
