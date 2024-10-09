using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coin;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ganaste una moneda");
            coin.PlayOneShot(coin.clip);
            Destroy(this.gameObject);
        }
    }
}