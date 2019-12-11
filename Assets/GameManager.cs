using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameOverCanvas;
    public Text scoreText;
    public Text finalScoreText;
    private int score = 0;
    public bool gameOver = false;
    public float scrollSpeed = 1.5f;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if(gameOver && Input.GetMouseButtonDown(0))
        {
            
        }
    }
    public void onPlayAgain()
    {
        if (gameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void OnQuitGame()
    {
        if (gameOver)
            Application.Quit();
    }

    public void birdScored()
    {
        if (gameOver) return;
        Debug.Log("point scored");
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void birdDied()
    {
        gameOverCanvas.SetActive(true);
        gameOver = true;
    }
}
