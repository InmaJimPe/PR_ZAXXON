using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speedx;
    float speedy;
    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {

        //movimimeto de la nave
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * x * speedx);
        transform.Translate(Vector3.up * Time.deltaTime * y * speedy);

        float posX = transform.position.x;
        float posY = transform.position.y;
        //limites
        if((posX > -12f && x < 0) || (posX < 12f && x > 0))
        {    
            speedx = 20;
        }
        else
        {
            speedx = 0;
        }

        if ((posY > -2.8f && y < 0) || (posY < 12f && y > 0))
        {
            speedy = 20;
        }
        else
        {
            speedy = 0;
        }
    }
}
