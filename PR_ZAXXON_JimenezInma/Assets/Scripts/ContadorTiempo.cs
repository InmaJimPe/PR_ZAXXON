using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorTiempo : MonoBehaviour
{
    public Text contador;
    public static float tiempo;


    // Start is called before the first frame update
    void Start()
    {
        tiempo = 0f;
        contador.text = " " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");
    }
}
