using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneLogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreAudioSource;
    public AudioSource gameOverAudioSource;

    public void AddScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
        scoreAudioSource.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMainMenu()
    {
        GameManagerScript.ReturnToTitleScreen();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        gameOverAudioSource.Play();
    }

    public void TogglePause()
    {
        if (Time.timeScale == 0)
        {
            Debug.Log("Resuming Game");
            Time.timeScale = 1f;
        } else
        {
            Debug.Log("Pausing Game");
            Time.timeScale = 0f;
        }
    }
}
