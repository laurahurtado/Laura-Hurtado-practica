using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileee : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int pastelesHorneados = 10;

        while (pastelesHorneados <= 15)
        {
            Debug.Log(pastelesHorneados);
            pastelesHorneados++;
        }

        Debug.Log("Los pastelitos estan horneados");

        for (int pastelitosHorneados = 10; pastelitosHorneados <= 15; pastelitosHorneados++)
        {
            Debug.Log(pastelitosHorneados);

        }
      
        }
    

        

        
    }



 

