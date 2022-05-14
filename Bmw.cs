using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Bmw : Araba, IAlman //Miras vermez.
{
    public bool UcuyorMu { get; set; }
    public bool AlmanMi { get; set; }

    public void AlmansatisYap()
    {
        if (AlmanMi)
        {
            ToplamFiyati -= 50000;
        }
    }

    public override void SatisYap()
    {
        ToplamFiyati = Fiyati;

        if (SifirMi)
        {
            ToplamFiyati += 7000m;
        }

    }

}
