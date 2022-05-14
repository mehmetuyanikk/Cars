using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainAraba : MonoBehaviour
{

    [SerializeField] InputField _markaField, _modelField, _hizField, _fiyatField;
    [SerializeField] Button _saveButton;
    
    void Start()
    {
        
    }

    //public void InputControl()
    //{
    //    if (_markaField != "" && _modelField != "" && _hizField != "" && _fiyatField != "")
    //    {
    //        _saveButton.interactable = true;
    //    }
    //}

    private void ArabaOlustur()
    {
        Bmw _bmw1 = new Bmw();
        _bmw1.Marka = "BMW";
        _bmw1.Model = "BM Model";
        _bmw1.SifirMi = true;
        _bmw1.Hizi = 250f;
        _bmw1.KapiSayisi = 2;
        _bmw1.Fiyati = 50000m;

        _bmw1.SatisYap();

        Debug.Log("BMW Fiyat: " + _bmw1.ToplamFiyati);

        Mercedes _mercedes1 = new Mercedes();
        _mercedes1.Marka = "Mercedes";
        _mercedes1.Model = "Mercedes Model";
        _mercedes1.SifirMi = true;

        _mercedes1.SatisYap();

        Ferrari _fer = new Ferrari();
        _fer.SifirMi = true;
        _fer.ZipliyorMu = true;
        _fer.Fiyati = 10m;

        _fer.SatisYap();

    }

    
    void Update()
    {
        
    }
}
