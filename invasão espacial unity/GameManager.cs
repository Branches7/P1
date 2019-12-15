using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    ScoreManager scoreManager;
    PlayerHealth playerHealth;

    void Start()
    {
        if(gameOverPanel != null) gameOverPanel.SetActive(false);
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (playerHealth != null)
        {
            if (playerHealth.isDead)
            {
                gameOverPanel.SetActive(true);
            }
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
    }
    public void MenuLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void Startgame()
    {
        SceneManager.LoadScene("Video");
    }
}
