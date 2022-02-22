using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Options()
    {
        SceneManager.LoadScene(3);

    }
    public void HS()
    {
        SceneManager.LoadScene(4);

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);

    }

    public void TryAgain()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Volver()
    {
        SceneManager.LoadScene(0);

    }
    public void Salir()
    {
        Application.Quit();

    }
    
}
