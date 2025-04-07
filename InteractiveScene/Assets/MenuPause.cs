using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject buttonpause;
    [SerializeField] private GameObject menupause;
    private bool pausedgame = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausedgame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
   {
        pausedgame = true;
        Time.timeScale = 0f;
        buttonpause.SetActive(false);
        menupause.SetActive(true);
    }

    public void Resume()
    {
        pausedgame = false;
        Time.timeScale = 1f;
        buttonpause.SetActive(true);
        menupause.SetActive(false);  
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
}

