using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject gameWinPanel;
    public GameObject tapToStart;
    public GameObject scoreText;
    public GameObject move;
   
    private void Start()
    {
        gameOverPanel.SetActive(false);
        gameWinPanel.SetActive(false);
        tapToStart.SetActive(true);
        scoreText.SetActive(false);
        
        PauseGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }

    public void GameOver()
    {
        scoreText.SetActive(false);
        gameOverPanel.SetActive(true);
        move.SetActive(false);
        StopAllCoroutines(); 
    }

    public void GameWin()
    {
        scoreText.SetActive(false);
        gameWinPanel.SetActive(true);
        move.SetActive(false);           //
    }

    public void Restart()
    {
        SceneManager.LoadScene("GAME");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        scoreText.SetActive(true);
        tapToStart.SetActive(false);
        Time.timeScale = 1f;
    }
}
