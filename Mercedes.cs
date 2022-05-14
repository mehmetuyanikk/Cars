using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercedes : Araba
{
    public bool YuzuyorMu { get; set; }

    public override void SatisYap()
    {
        ToplamFiyati = Fiyati;

        if (SifirMi)
        {
            ToplamFiyati += 7000m;
        }

    }

}
