using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnHoops : MonoBehaviour
{
    public GameObject[] hoops;
    public Vector3 offset;
    public Vector3 vec;
    public GameObject player;
    GameObject spawnedHoop;
    List<GameObject> createdHoops = new List<GameObject>();
    

    public void SpawnObjects()
    {
        //create objects
        for (int i = 0; i < 10; i++)
        {
            int hoops_num = Random.Range(0, hoops.Length);
            offset = new Vector3(0, 0, Random.Range(15f, 25f));
            Vector3 pos = transform.position + offset + vec;
            spawnedHoop = Instantiate(hoops[hoops_num], pos, hoops[hoops_num].transform.rotation);
            vec = spawnedHoop.transform.position;
            //add to list
            createdHoops.Add(spawnedHoop);
        }
        
    }

    public void DestroyAndCreateNewHoops()
    {
        //compare positions of hoop and player
        if ((createdHoops[0].transform.position.z + 5) < player.transform.position.z)
        {
            //destroy hoops
            Destroy(createdHoops[0]);
            createdHoops.RemoveAt(0);
            //and create new
            int hoops_num = Random.Range(0, hoops.Length);
            offset = new Vector3(0, 0, Random.Range(20f, 30f));
            Vector3 pos = transform.position + offset + vec;
            spawnedHoop = Instantiate(hoops[hoops_num], pos, hoops[hoops_num].transform.rotation);
            vec = spawnedHoop.transform.position;
            //add to list
            createdHoops.Add(spawnedHoop);
        }
    }
    
    public void Start()
    {
        SpawnObjects();
    }

    public void Update()
    {
        DestroyAndCreateNewHoops();
    }




}
