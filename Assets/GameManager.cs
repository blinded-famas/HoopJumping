﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 5f;
    public GameObject endGameMenuUI;
    public GameObject scoreCounterUI;
    public GameObject player;
    

    public void Start()
    {
        Time.timeScale = 0f;
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            FindObjectOfType<Score>().setScoreValue();
            FindObjectOfType<Score>().setHighscoreValue();
            FindObjectOfType<OctahedronsCollectingAndStoring>().setOctahedronsValue();
            player.GetComponent<PlayerModelSwitch>().enabled = false;
            DisableEndGameMenu();
            Debug.Log("Game END");
            //Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void DisableEndGameMenu()
    {
        endGameMenuUI.SetActive(true);
        scoreCounterUI.SetActive(false);
        //Time.timeScale = 0f;
        gameHasEnded = true;
    }
}
