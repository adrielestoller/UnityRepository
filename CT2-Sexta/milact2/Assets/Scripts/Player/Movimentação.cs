using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour

{
    public float velocidade;
    public float rotacao;

    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate ()
    {
        rb.velocity = transform.up * velocidade;

    }
    
    void Update()
    {
        transform.Rotate(0f, 0f, -Input.GetAxis("Horizontal") * rotacao);
    }
}
