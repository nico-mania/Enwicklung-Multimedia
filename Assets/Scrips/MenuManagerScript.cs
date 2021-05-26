using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public GameObject Menu;
    public static bool GameisPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Return();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Return()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    public void Pause()
    {
        Debug.Log("Game is paused");
        Menu.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Menu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
}

