using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa : MonoBehaviour
{
    [SerializeField] float vida, vidaMaxima = 1f;
    
    void Start()
    {
        vida = vidaMaxima;
    }

    void Update()
    {
        
    }

    public void TakeDamage(float damageAmount)
    {
        vida -= damageAmount;

        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
