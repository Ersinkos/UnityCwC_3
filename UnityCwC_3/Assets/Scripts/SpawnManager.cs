using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    public int obstacleIndex;
    private PlayerController playerController;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnObstacles()
    {
        obstacleIndex = Random.Range(0, obstacles.Length);
        if (!playerController.gameOver)
        {
            Instantiate(obstacles[obstacleIndex], spawnPos, obstacles[obstacleIndex].transform.rotation);
        }
    }
}
