using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTest : MonoBehaviour
{
    CountdownTool countdownTool;
    float baslangicZamani;
    // Start is called before the first frame update
    //CountdownTool adlı kod bloğuna erişim sağlayarak o dizindeki sayaç süresine 
    // değer ataması yapar, kullanımı zorunlu değil kontrol amaçlı yazıldı.
    void Start()
    {
        countdownTool = gameObject.AddComponent<CountdownTool>();
        countdownTool.ToplamSure = 3;
        countdownTool.Calistir();

        baslangicZamani = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownTool.Bitti)
        {
            float gecenSure = Time.time - baslangicZamani;
            Debug.Log(gecenSure);

            baslangicZamani = Time.time;
            countdownTool.Calistir();
               
        }
    }
}
