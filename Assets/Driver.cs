using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Variáveis Globais
    //[SerializeField] -> Indica que a variável não será fixa.
    [SerializeField] float velocidadeDirecao = 300f;
    [SerializeField] float velocidadeMovimento = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    private static string tagBoost = "Boost";

    void Update()
    {
        //Time.deltaTime -> Executa os frames em computadores lentos
        //Input.GetAxis("Horizontal") -> Valores pré fixados para o keyboard 
        //Input.GetAxis("Vertical") -> Valores pré fixados para o keyboard 

        float velocidadeAmount = Input.GetAxis("Horizontal") * velocidadeDirecao * Time.deltaTime;
        float movimentoAmount = Input.GetAxis("Vertical") * velocidadeMovimento * Time.deltaTime;

        transform.Rotate(0, 0, -velocidadeAmount);
        transform.Translate(0, movimentoAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        velocidadeMovimento = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == tagBoost)
        {
            velocidadeMovimento = boostSpeed;
        }
    }
}
