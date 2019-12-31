using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OctahedronsCollectingAndStoring : MonoBehaviour
{
    public Text octahedronsTextField;
    private int octahedronsValue;
    private int octahedronsCurrentGameValue;


    private void Start()
    {
        octahedronsValue = PlayerPrefs.GetInt("Octahedrons", 0);
        octahedronsTextField.text = PlayerPrefs.GetInt("Octahedrons", 0).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Octahedron")
        {
            octahedronsCurrentGameValue += 1;
            octahedronsTextField.text = (octahedronsValue + octahedronsCurrentGameValue).ToString();
        }

    }

    public void setOctahedronsValue()
    {
        PlayerPrefs.SetInt("Octahedrons", octahedronsValue + octahedronsCurrentGameValue);
        PlayerPrefs.Save();
    }
}

