using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Familia : MonoBehaviour
{

    public FamiliasGameOfThrones Familia1;
    public FamiliasGameOfThrones Familia2;

    private void Start()
    {
        Familia1 = new FamiliasGameOfThrones();
        Familia1.nombre = "Winterfell";
        Familia1.lema = "Winter is coming";
        Familia1.ubicación = "Invernalia";
        Familia1.miembrosDestacados = 9;
        Familia1.buenos = true;

        Familia2 = new FamiliasGameOfThrones();
        Familia2.nombre = "Lannister";
        Familia2.lema = "Hear me Roar!";
        Familia2.ubicación = "Casterly Rock";
        Familia2.miembrosDestacados = 7;
        Familia2.malos = false;


    }

}
