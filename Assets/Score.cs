using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Text score;
    int playerScore = 0;
    public bool triggerCheck = true;
    

    private void OnTriggerEnter(Collider other)
    {
        if (triggerCheck == true)
        {
            playerScore += 1;
            score.text = playerScore.ToString();
        }
        
    }

}
