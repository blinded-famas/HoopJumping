using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHoops : MonoBehaviour
{
    public GameObject[] hoops;
    public Vector3 offset;
    public GameObject cameraObj;
    public float respawnTime = 0.25f;

    public void Start()
    {
        StartCoroutine(HoopsSpawningCoroutine());
    }
    void CreateHoop()
    {
        int hoops_num = Random.Range(0, 3);
        offset = new Vector3(0, 0, Random.Range(15f, 20f));
        Vector3 pos = new Vector3(0,0,cameraObj.transform.position.z) + offset;
        GameObject createdHoop;
        createdHoop = Instantiate(hoops[hoops_num], pos, hoops[hoops_num].transform.rotation);
    }

    IEnumerator HoopsSpawningCoroutine() 
    { 
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            CreateHoop();
        }
        
    }
}
