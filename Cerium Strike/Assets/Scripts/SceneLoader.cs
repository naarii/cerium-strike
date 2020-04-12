using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float loadWaitTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadFirstScene", loadWaitTime);
    }

    void LoadFirstScene() // Called by string reference
    {
        SceneManager.LoadScene(1);
    }
}
