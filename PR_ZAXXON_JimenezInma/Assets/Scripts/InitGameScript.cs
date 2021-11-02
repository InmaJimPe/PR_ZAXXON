using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{
   
    public float spaceshipSpeed;
    public int levelGame;
    public bool alive;
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 20f;
        alive = true;

    }

    // Update is called once per frame
    void Update()
    {

       

    }

    public void Morir()
    {
        print("he morido");
        alive = false;
        spaceshipSpeed = 0f;
        Creator instanciadorObst = GameObject.Find("InstanciadorObst").GetComponent<Creator>();
        instanciadorObst.SendMessage("Para");

        //SceneManager.LoadScene(2);
    }


}
