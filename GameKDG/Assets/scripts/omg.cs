using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omg : MonoBehaviour
{
    public float moveSpeed = 7.0f;
    public float jumpForce = 5.0f; // Fuerza del salto
    public Transform camara;

    private Rigidbody rb;
    private bool isGrounded; // Estado de si está en el suelo

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Movimiento
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 forward = camara.forward;
        Vector3 right = camara.right;

        // Ajustar y a 0 para no movernos verticalmente
        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = (forward * moveZ + right * moveX);

        // Mostrar información en la consola
        Debug.Log($"Movimiento: X = {moveX}, Z = {moveZ}, Dirección = {moveDirection}");

        // Aplicar movimiento
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);

        // Salto
        if (Input.GetButtonDown("Jump") && isGrounded) // Comprobar si está en el suelo
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // El jugador ya no está en el suelo
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Comprobar si el jugador colisiona con el suelo
        if (collision.gameObject.CompareTag("floor"))
        {
            isGrounded = true; // El jugador está en el suelo
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Comprobar si el jugador sale del suelo
        if (collision.gameObject.CompareTag("Suelo"))
        {
            isGrounded = false; // El jugador ya no está en el suelo
        }
    }
}
