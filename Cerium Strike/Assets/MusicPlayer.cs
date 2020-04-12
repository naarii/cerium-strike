using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] float loadWaitTime = 3f;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Start()
    {       
        Invoke("LoadFirstScene", loadWaitTime);      
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
