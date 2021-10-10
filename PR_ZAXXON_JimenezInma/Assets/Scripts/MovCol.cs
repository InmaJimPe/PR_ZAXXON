using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCol : MonoBehaviour
{
   
    

    float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        float posZ = transform.position.z;
        

        if (posZ < -30)
        {
            Destroy(gameObject);
        }




    }


}
