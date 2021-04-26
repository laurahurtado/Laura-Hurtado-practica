using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    public string[] mejoresDirectoresCine = new string[] { "Nolan", "Tarantino", "Anderson", "Coppola" };

    private void Start()
    {
        print(mejoresDirectoresCine[0]);
        mejoresDirectoresCine[0] = "Interstellar";
        print(mejoresDirectoresCine[0]);

        print(mejoresDirectoresCine[1]);
        mejoresDirectoresCine[1] = "Pulp Fiction";
        print(mejoresDirectoresCine[1]);

        print(mejoresDirectoresCine[2]);
        mejoresDirectoresCine[2] = "The Grand Budapest Hotel";
        print(mejoresDirectoresCine[2]);

        print(mejoresDirectoresCine[3]);
        mejoresDirectoresCine[3] = "Godfather";
        print(mejoresDirectoresCine[3]);

    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
