﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTool : MonoBehaviour
{
    float toplamSure = 0;
    float gecenSure = 0;
    bool calisiyor = false;
    bool basladi = false;

    /// <summary>
    /// Geri sayım sayacının toplam süresini ayarlar
    /// </summary>
    public float ToplamSure
    {
        set
        {
            if (!calisiyor == true)
            {
                toplamSure = value;
            }
        }
    }
    /// <summary>
    /// Geri sayımın bitip bitmediğini söyler
    /// </summary>
    public bool Bitti
    {
        get
        {
            return basladi && !calisiyor;
        }
    }

    /// <summary>
    /// Sayacı Çalıştırır 
    /// </summary>
    public void Calistir()
    {
        if (toplamSure > 0)
        {
            calisiyor = true;
            basladi = true;
            gecenSure = 0;
        }
    }

   //Update içindeki kod bloğu toplam zaman ile geçen süre koşuluna bakar

    // Update is called once per frame
    void Update()
    {
        if (calisiyor)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure >= toplamSure)
            {
                calisiyor = false;
            }
        }
    }
}
