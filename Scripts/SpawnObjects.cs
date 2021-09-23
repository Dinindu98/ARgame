using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject jumpingCube;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(1);

        jumpingCube.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;

        StartCoroutine(StartSpawning());
        
    }
}
