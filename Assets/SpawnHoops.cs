using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnHoops : MonoBehaviour
{
    public GameObject[] hoops;
    public Vector3 offset;
    public GameObject cameraObj;
    public float respawnTime = 0.25f;
    List <GameObject> list;
    

    public void Start()
    {
        list = new List<GameObject>();
        while (list.Count < 10)
        {
            int hoops_num = Random.Range(0, 3);
            offset = new Vector3(0, 0, Random.Range(20f, 20f));
            Vector3 pos = transform.position + offset;
            GameObject spawnedHoop;
            list.Add(spawnedHoop = Instantiate(hoops[hoops_num], pos, hoops[hoops_num].transform.rotation));
            if (list.Count == 10)
            {
                Destroy(list.First().gameObject);
                list.Remove(list.First());
            }
        }
    }

   


}
