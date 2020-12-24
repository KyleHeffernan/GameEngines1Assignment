using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{

    public GameObject terrainPrefab;

    public GameObject terrainPrefab2;

    private GameObject terrainPrefabCopy;

    public float speed = 1;
    private float audioSpeed;
    public GameObject player;
    public float moveDistance = 10;
    public float spawnDistance = 100;

    private int counter;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= transform.forward * speed * Time.deltaTime;
        if(Vector3.Distance(player.transform.position, transform.position) < spawnDistance)
        {
            Spawn();
        }
        
    }

    void Spawn()
    {
        // Every fifth terrain generated has a streetlamp
        counter++;
        if(counter % 5 == 0)
        {
            terrainPrefabCopy = terrainPrefab;
        }
        else
        {
            terrainPrefabCopy = terrainPrefab2;
        }
        // Instatiating new terrain and adding the movement script onto it, moving it towards the camera
        GameObject terrain = GameObject.Instantiate<GameObject>(terrainPrefabCopy, transform.position, transform.rotation);
        MoveTerrain moveScript = terrain.AddComponent<MoveTerrain>();
        moveScript.speed = speed;
        transform.position = transform.position + (-transform.forward * (moveDistance * terrain.transform.localScale.x));
    }



}
