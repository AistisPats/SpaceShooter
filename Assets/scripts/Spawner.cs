using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Meteorite;
    public int SpawnCount;
    public float mapSize;

    void Start()
    {
        for(int i = 0; i < SpawnCount; i++)
        {
            Instantiate(Meteorite, new Vector2(Random.Range(mapSize, -mapSize), Random.Range(mapSize, -mapSize)), Quaternion.Euler(0, 0, 0));
        }
    }
}
