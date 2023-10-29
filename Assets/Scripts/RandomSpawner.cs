using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cube;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-8, 5),0, Random.Range(-3, 5));
            Instantiate(cube, randomSpawnPosition, Quaternion.identity);
        }
    }
}
