using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GanadoresPremios : MonoBehaviour
{
    public List<Premio> premios = new List<Premio>();
    public string[] peliculasNomidas = new string[] { "Parasito", "mujercitas", "Once Upon A time in Hollywood", "jojo rabitt", "joker" };
    public List<float> mayorPuntaje = new List<float>();
  

   
    void Start()
    {
 
        premios.Add(new Premio("Parasitos", 90));
        premios.Add(new Premio("Mujercitas", 60));
        premios.Add(new Premio("Once Upon A time in Hollywood", 80));
        premios.Add(new Premio("jojo rabitt", 50));
        premios.Add(new Premio("joker", 100));

        mayorPuntaje.Add(900f);
        mayorPuntaje.Add(650f);
        mayorPuntaje.Add(865f);
        mayorPuntaje.Add(500f);
        mayorPuntaje.Add(1000f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
