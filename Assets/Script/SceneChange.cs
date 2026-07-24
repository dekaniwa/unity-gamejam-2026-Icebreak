using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if(TimerManager. Instance !=null)
        {
            TimerManager.Instance.OnTimeUp += GameCLEAR;
        }
          
    }

    private void OnDestroy()
    {
        
        
          TimerManager.Instance.OnTimeUp -= GameCLEAR;
        
    }

    void Title()
    {
        SceneManager.LoadScene("cube");
    }

    void GameCLEAR()
    {
        SceneManager.LoadScene("Gameclear");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            Invoke("Title", 1.5f);
        }

    }
}
