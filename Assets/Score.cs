using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Text score;
    public GameObject hoops;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Hoops")
        {
            Debug.Log("DETECTED");
        }
    }
}
