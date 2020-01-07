using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject MainMenuUI;
    public ScriptableObject PlayButtonScript;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1f;
            MainMenuUI.SetActive(false);
            GetComponent<PlayButton>().enabled = false;
            
        }
    }
}
