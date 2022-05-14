using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Araba //Miras verir, newlenemez.
{

    // Virtual et, ez (override)

    public string Marka { get; set; }

    public string Model { get; set; }

    public bool SifirMi { get; set; }

    public float Hizi { get; set; }

    public byte KapiSayisi { get; set; }

    public decimal Fiyati { get; set; }

    public decimal ToplamFiyati { get; protected set; }

    public virtual void SatisYap() // Sanal method, yani ezilebilir
    {
        ToplamFiyati = Fiyati;

        if (SifirMi)
        {
            ToplamFiyati += 7000m;
        }


    }

}
