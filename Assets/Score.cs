using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Text score;
    int playerScore = 0;
    

    private void OnTriggerEnter(Collider other)
    {
        playerScore += 1;
        score.text = playerScore.ToString();
    }

}
