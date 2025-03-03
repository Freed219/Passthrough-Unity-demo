using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPause : MonoBehaviour
{
    private InputManager inputManager;

    public GameObject PauseMenu;

    public GameObject ConfigMenu;

    public static bool GameIsPaused = false;

    public static bool GameIsBeingConfig = false;

    void Start()
    {
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inputManager.onFoot.Escape.triggered)
        {   

            Debug.Log("YES");
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        ConfigMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ConfigureGame()
    {
        ConfigMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void ExitConfig()
    {
        ConfigMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void ExitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
