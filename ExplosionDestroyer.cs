using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroyer : MonoBehaviour
{
    CountdownTool countdowntool;
    // Start is called before the first frame update
    void Start()
    {
        countdowntool = gameObject.AddComponent<CountdownTool>();
        countdowntool.ToplamSure = 1;
        countdowntool.Calistir();


    }

    // Update is called once per frame
    void Update()
    {
        if (countdowntool.Bitti)
        {
            Destroy(gameObject);
        }
    }
}
