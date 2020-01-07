using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOctahedrons : MonoBehaviour
{
    public GameObject octahedron;
    private Vector3 spawnOffset;
    private Vector3 positionOfOctahedronSpawning;
    public GameObject player;
    GameObject spawnedOctahedron;
    List<GameObject> createdOctahedrons = new List<GameObject>();


    public void FirstSpawnOctahedrons()
    {
        //create objects
        for (int i = 0; i < 10; i++)
        {
            spawnOffset = new Vector3(0, 0, Random.Range(10f, 30f));
            Vector3 pos = transform.position + spawnOffset + positionOfOctahedronSpawning;
            spawnedOctahedron = Instantiate(octahedron, pos, octahedron.transform.rotation);
            positionOfOctahedronSpawning = spawnedOctahedron.transform.position;
            //add to list
            createdOctahedrons.Add(spawnedOctahedron);
        }

    }

    public void DestroyAndCreateNewOctahedrons()
    {
        //compare positions of octahedron and player
        if ((createdOctahedrons[0].transform.position.z + 0.1) < player.transform.position.z)
        {
            //destroy hoops
            Destroy(createdOctahedrons[0]);
            createdOctahedrons.RemoveAt(0);
            //and create new
            spawnOffset = new Vector3(0, 0, Random.Range(10, 30f));
            Vector3 pos = transform.position + spawnOffset + positionOfOctahedronSpawning;
            spawnedOctahedron = Instantiate(octahedron, pos, octahedron.transform.rotation);
            positionOfOctahedronSpawning = spawnedOctahedron.transform.position;
            //add to list
            createdOctahedrons.Add(spawnedOctahedron);
        }
    }

    public void Start()
    {
        FirstSpawnOctahedrons();
    }

    public void Update()
    {
        DestroyAndCreateNewOctahedrons();
    }
}
