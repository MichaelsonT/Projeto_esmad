using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJogador : MonoBehaviour
{
    [SerializeField] float vida, vidaMaxima = 5f;
    private GameManager reniciarnivel;
    private GameObject nave;

    void Start()
    {
        vida = vidaMaxima;
        reniciarnivel = GameObject.FindObjectOfType<GameManager>();
    }


    void Update()
    {
        
    }

    public void TakeDamage(float damageAmount)
    {
        vida -= damageAmount;

        if(vida <= 0)
        {            
            OnSetActive();
            nave.SetActive(false);

        }
    }

     private void OnSetActive()
    {
        if (gameObject.CompareTag("Player"))
        {
            reniciarnivel.RestartLevel();
        }
    }
}
