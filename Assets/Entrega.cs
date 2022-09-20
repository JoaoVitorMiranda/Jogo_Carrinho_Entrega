using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega : MonoBehaviour
{
    private static string TagPacote = "Pacote";
    private static string TagLocalEntrega = "LocalEntrega";
    bool temPacote;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 temPacoteColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 naoTemPacoteColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
//    private void OnCollisionEnter2D(Collision2D other) 
//    {
//        UnityEngine.Debug.Log("Colisão com o objeto");
//    }

   private void OnTriggerEnter2D(Collider2D other) 
   {
       if (other.tag == TagPacote && temPacote == false)
       {
            UnityEngine.Debug.Log("Pacote");
            temPacote = true;
            spriteRenderer.color = temPacoteColor;
            Destroy(other.gameObject, destroyDelay);
       }

       if (other.tag == TagLocalEntrega && temPacote)
       {
            UnityEngine.Debug.Log("Local da entrega!");
            temPacote = false;
            spriteRenderer.color = naoTemPacoteColor;
       }
   }
}
