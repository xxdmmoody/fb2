using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPool : MonoBehaviour
{
    public GameObject wallPrefab;
    public float spawnRate = 31f;
    private int wallPoolSize = 5;
    private float maxHeight = 1f;
    private float minHeight = -1f;
    private float timeSinceLastSpawned;
    private float spawnXposition = 5f;
    private int currentWall = 0;
    private Vector2 objectPoolPosition = new Vector2(-5f, 0f);




    private GameObject[] walls;

    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastSpawned = 0f;
        walls = new GameObject[wallPoolSize];
        for (int i = 0; i < wallPoolSize; i++)
        {
            walls[i] = (GameObject)Instantiate(wallPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameOver == false)
        {
            timeSinceLastSpawned += Time.deltaTime;

            if (timeSinceLastSpawned >= spawnRate)
            {
                timeSinceLastSpawned = 0f;
                float spawnYposition = Random.Range(minHeight, maxHeight);
                walls[currentWall].transform.position = new Vector2(spawnXposition, spawnYposition);
                currentWall++;
                if (currentWall >= wallPoolSize)
                {
                    currentWall = 0;
                }
            }
        }
       
    }
}
