using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnHoops : MonoBehaviour
{
    public GameObject[] hoops;
    public Vector3 offset;
    public Vector3 vec;

    void SpawnObjects()
    {
        for (int i = 0; i < 15; i++)
        {
            int hoops_num = Random.Range(0, hoops.Length);
            offset = new Vector3(0, 0, Random.Range(20f, 30f));
            Vector3 pos = transform.position + offset + vec;
            GameObject spawnedHoop = Instantiate(hoops[hoops_num], pos, hoops[hoops_num].transform.rotation);
            vec = spawnedHoop.transform.position;
        }
    }

    
    public void Update()
    {
        SpawnObjects();
        
    }




}
