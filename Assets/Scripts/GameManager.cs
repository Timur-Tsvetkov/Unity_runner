using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public PlayerMovement movement;

    public GameObject obstaclePrefab;
    public Transform obstacles;
    public int obstacleStartX = 100;
    public static int difficulty = 1;

    private void Spawn()
    {
        int i;
        for (i = -7; i < 7; i += 7)
        {
            Instantiate(obstaclePrefab, 
                new Vector3(UnityEngine.Random.Range(i, i + 7), 1, obstacleStartX), Quaternion.identity, obstacles);
        }
    }
    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 0.5f);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
