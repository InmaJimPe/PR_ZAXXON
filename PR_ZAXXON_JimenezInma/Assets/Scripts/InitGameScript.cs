using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{
    public int vida;
    public float spaceshipSpeed;
    public int levelGame;
    public bool alive;
    [SerializeField] GameObject fantasmaPrefab;
    [SerializeField] GameObject explosion;
    bool active;
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 20f;
        alive = true;
        vida = 1;
        explosion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {



    }

    public void Morir()
    {

        active = !active;
        Time.timeScale = (active) ? 0 : 1f;

        SceneManager.LoadScene(2);
    }
    public void Chocar()
    {
        vida -= 1;
        if (vida == 0)
        {
            
            fantasmaPrefab.SetActive(false);
            explosion.SetActive(true);
            Invoke("Morir", 1.5f);

        }


    }

}
