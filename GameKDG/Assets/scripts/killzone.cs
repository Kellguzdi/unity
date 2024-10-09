using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public GameObject spawn;
    public AudioSource muerte;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = spawn.transform.position;
            muerte.PlayOneShot(muerte.clip);
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Debug.Log("Entro el jugador, se pasara al spawn");
        }
    }
    
}