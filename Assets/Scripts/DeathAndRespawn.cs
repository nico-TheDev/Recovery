using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAndRespawn : MonoBehaviour
{
    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("Collided with enemy or death");
        print(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(scene.buildIndex);
        }

    }
}
