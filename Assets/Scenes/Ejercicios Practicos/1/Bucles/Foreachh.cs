using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreachh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //array//

        int[] pasteles = { 2, 4, 6, 8, 10 };

        //Recorrer un array con bucle for//

        for (int p = 0; p < pasteles.Length; p++ )
        { Debug.Log(pasteles[p]); }

        //foreach

        foreach (int pastel in pasteles)
        { Debug.Log(pastel); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
