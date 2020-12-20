﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{

    public GameObject terrainPrefab;
    public float speed = 1;
    private float audioSpeed;
    public GameObject player;
    public float moveDistance = 10;
    public float spawnDistance = 100;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //audioSpeed = speed * AudioAnalyzer.smoothedAmplitude * 100;
        transform.position+= transform.forward * speed * Time.deltaTime;
        if(Vector3.Distance(player.transform.position, transform.position) < spawnDistance)
        {
            Spawn();
        }
        
    }

    void Spawn()
    {
        
        GameObject terrain = GameObject.Instantiate<GameObject>(terrainPrefab, transform.position, transform.rotation);
        MoveTerrain moveScript = terrain.AddComponent<MoveTerrain>();
        moveScript.speed = speed;
        transform.position = transform.position + (-transform.forward * (moveDistance * terrain.transform.localScale.x));
    }



}
