using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    
    public TextMeshProUGUI LivesText;
    public TextMeshProUGUI ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this._updateUI();
    }

    public void ReduceLives()
    {
        this.lives--;
    }

    public void IncreaseScore()
    {
        this.score++;
    }

    private void _updateUI()
    {
        this.LivesText.SetText($"Lives: {this.lives}");
        this.ScoreText.SetText($"Score: {this.score}");
    }
}
