using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{

    [SerializeField] GameObject columna;
    [SerializeField] Transform initpos;
    float separacion;
    float intervalo;
    //[SerializeField] GameObject initObject;
    
    
   

    //[SerializeField] int numFila = 5;
    // Start is called before the first frame update
    void Start()
    {

        intervalo = 0.25f;

        StartCoroutine("CrearObstaculos");

        
              

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    IEnumerator CrearObstaculos()
    {
        
        Vector3 newPos = initpos.position;
        while (true)
        {
            separacion = Random.Range(-12f, 12f);
            Vector3 despl = new Vector3(separacion, 0f, initpos.position.z);
            Instantiate(columna, despl, Quaternion.identity);
            //newPos = newPos + despl;
            yield return new WaitForSeconds(intervalo);


        }

    }








}




