using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rutina : MonoBehaviour
{
    public GameObject miEsfera;
    private float tiempo;

    void Start()
    {
        Apagar();
    }
    public void Apagar()
    {
        StartCoroutine(W_Apagar());
    }
    IEnumerator W_Apagar()
    {
        tiempo = Random.Range(0.5f, 3.0f);
        miEsfera.SetActive(false);
        yield return new WaitForSeconds(tiempo);
        miEsfera.SetActive(true);
        yield return new WaitForSeconds(tiempo);
        Apagar();
        
    }
}
