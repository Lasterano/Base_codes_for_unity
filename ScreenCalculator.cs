using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenCalculator 
{
    static float sol;
    static float sag;
    static float ust;
    static float alt;

    /// <summary>
    /// Ekran?n SOL kenar?n?n koordinatlar?n? verir
    /// </summary>
    public static float Sol
    {
        get
        {
            return sol;
        }
    }
    /// <summary>
    /// Ekran?n SA? kenar?n?n koordinatlar?n? verir
    /// </summary>
    public static float Sag
    {
        get
        {
            return sag;
        }
    }
    /// <summary>
    /// Ekran?n ÜST kenar?n?n koordinatlar?n? verir
    /// </summary>
    public static float Ust
    {
        get
        {
            return ust;
        }
    }
    /// <summary>
    /// Ekran?n ALT kenar?n?n koordinatlar?n? verir
    /// </summary>
    public static float Alt
    {
        get
        {
            return alt;
        }
    }

    public static void Init()
    {
        float ekranZekseni = -Camera.main.transform.position.z;
        Vector3 solAltKose = new Vector3(0, 0, ekranZekseni);
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZekseni);

        Vector3 solAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(sagUstKose);

        sol = solAltKoseOyunDunyasi.x;
        sag = sagAltKoseOyunDunyasi.x;
        ust = sagAltKoseOyunDunyasi.y;
        alt = sagAltKoseOyunDunyasi.y;
    }
}
