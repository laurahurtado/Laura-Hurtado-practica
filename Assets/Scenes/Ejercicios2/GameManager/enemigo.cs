using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    private int daño = -1;
    public GameManager  gameManager;
    public string killplayer;
    public playercontroller GetInstance;


    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Debug.Log("enemigo tocado");
            gameManager.salud(daño);
        }
    }
}

