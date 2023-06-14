using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    
        if(collision.gameObject.TryGetComponent<Inimigo>(out Inimigo enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }

        if(collision.gameObject.TryGetComponent<Caixa>(out Caixa neutralComponent))
        {
            neutralComponent.TakeDamage(1);
        }

        if(collision.gameObject.TryGetComponent<VidaJogador>(out VidaJogador playerComponent))
        {
            playerComponent.TakeDamage(1);
        }
    }
}
