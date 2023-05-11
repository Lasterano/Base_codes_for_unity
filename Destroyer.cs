using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;

    CountdownTool destroyerCountdown;

    // Start is called before the first frame update
    //Random.Range (1,20); 1-20 sn arasında rastgele sayı oluşturur
    //Oluşturulan sayılar "ToplamSure"(destroyerCountdown da kuşlanılan) içine atanır

    void Start()
    {
        destroyerCountdown = gameObject.AddComponent<CountdownTool>();
        destroyerCountdown.ToplamSure = Random.Range(1, 20);
        destroyerCountdown.Calistir();
    }

    // Update is called once per frame
    // patlamaPrefab kullanılan prefab ta kullanılacak
    // Destroy ise oluşan objeleri belli süre zarında yok edecek
    // "Bitti" sayaç kodundan çekildi
    void Update()
    {
        if (destroyerCountdown.Bitti)
        {
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
        
    }
}
