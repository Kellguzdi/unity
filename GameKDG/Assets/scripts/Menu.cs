using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void Salir()
    {
        Application.Quit();
    }
}
