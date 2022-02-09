using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{
   
    public float spaceshipSpeed;
    public int levelGame;
    public bool alive;
    [SerializeField] GameObject fantasmaPrefab;
    bool active;
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

        fantasmaPrefab.SetActive(false);

        active = !active;
        Time.timeScale = (active) ? 0 : 1f;
        //yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }


}
