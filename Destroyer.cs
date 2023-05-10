using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;

    CountdownTool destroyerCountdown;

    // Start is called before the first frame update
    void Start()
    {
        destroyerCountdown = gameObject.AddComponent<CountdownTool>();
        destroyerCountdown.ToplamSure = Random.Range(1, 20);
        destroyerCountdown.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyerCountdown.Bitti)
        {
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
        
    }
}
