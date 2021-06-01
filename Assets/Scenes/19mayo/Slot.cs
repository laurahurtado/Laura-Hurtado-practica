using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    inventario Inventary;
    public int Iteracion;



        void Start()
        {
            Inventary = GameObject.FindGameObjectWithTag("Player").GetComponent<inventario>();

        }
    


        void Update()
        {
        if (transform.childCount <= 0) 
        {
            Inventary.isFull[Iteracion] = false;
        }

        }




    public void DropItem()

    {
        foreach (Transform item in transform)
        {
            GameObject.Destroy(item.gameObject);
        }

    }

}
