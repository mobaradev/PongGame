using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;
    
    
    void Start()
    {
        this._loadHighScore();
    }

    public void Play() 
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void _loadHighScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        
        this.HighScoreText.SetText("High score: " + highScore.ToString());
    }
}
