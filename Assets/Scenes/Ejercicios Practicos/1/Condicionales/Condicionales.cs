using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    public int PastelesHorneados = 10;
    public int _Clientes = 5; 
    void Start()
    {
        if (PastelesHorneados > _Clientes)
        {
            print("No debes hornear mas parteles ");
        }

        else
        {
            print("Debes hornear mas pasteles"); 
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
