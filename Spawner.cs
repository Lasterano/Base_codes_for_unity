using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;
    CountdownTool countdownTool;
    // Start is called before the first frame update
    void Start()
    {
        countdownTool = gameObject.AddComponent<CountdownTool>();
        countdownTool.ToplamSure = 3;
        countdownTool.Calistir();

    }

    // Update is called once per frame
    void Update()
    {
        if (countdownTool.Bitti)
        {
            //Spawn Game Object
            SpawnAsteroid();
            countdownTool.Calistir();
        }
    }

    void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab);
    }
}
