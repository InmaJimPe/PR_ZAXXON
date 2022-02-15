using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiempoFinal : MonoBehaviour
{
    public Text contadorFinal;
    float tiempoFin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoFin = ContadorTiempo.tiempo;
        contadorFinal.text = " " + tiempoFin.ToString("f0");
    }
}
