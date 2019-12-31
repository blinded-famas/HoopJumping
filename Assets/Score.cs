using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Text score;
    public int playerScore;
    public bool triggerCheck = true;
    public Text scoreValueText;
    public Text highscoreValueText;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle" && triggerCheck == true)
        {
            playerScore += 1;
            score.text = playerScore.ToString();
        }
        
    }

    public void setScoreValue()
    {
        scoreValueText.text = playerScore.ToString();
    }

    public void setHighscoreValue()
    {
        highscoreValueText.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
        if (playerScore > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", playerScore);
            highscoreValueText.text = playerScore.ToString(); 
        }
    }

}
