using UnityEngine;
using System.Collections;

public class StuffSpawner : MonoBehaviour
{
    public Transform[] StuffSpawnPoints;
    public GameObject[] Bonus;
    public GameObject[] Obstacles;

    public bool RandomX = false;
    public float minX = -2f, maxX = 2f;

    void CreateObject(Vector3 position, GameObject prefab)
    {
        if (RandomX) 
            position += new Vector3(Random.Range(minX, maxX), 0, 0);

        Instantiate(prefab, position, Quaternion.identity);
    }
}
