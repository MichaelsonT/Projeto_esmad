using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    [SerializeField] float vida, vidaMaxima = 3f;
    NavMeshAgent agente;
    Transform alvo;
    private GameObject jogador;

    void Start()
    {
        agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
        alvo = GameObject.FindGameObjectWithTag("Player").transform;
        vida = vidaMaxima;
        jogador = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        agente.destination = alvo.position;

        if (jogador != null)
        {
            Vector3 direction = jogador.transform.position - transform.position;
            direction.y = 0f;
            if (direction != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }
    /*private void OnCollisionEnter(Collision other) 
    {
      if(other.gameObject.CompareTag("Player")){
         Interface.gameover = true;
      }
    }*/

    public void TakeDamage(float damageAmount)
    {
        vida -= damageAmount;

        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
