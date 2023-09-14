using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject route;
    [SerializeField] private float timeToSpawn;
    float time;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time == timeToSpawn) {
            // Instantiate(enemy, transform.position, )
        }
    }
}
