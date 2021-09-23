using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    private Vector3 newPosition;
    public float speed; 
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(1);

        newPosition = spawnPoints[Random.Range(0, spawnPoints.Length)].position;

        StartCoroutine(StartSpawning());

    }
}
