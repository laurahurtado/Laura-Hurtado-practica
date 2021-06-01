using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{

    inventario Inventory;
    public GameObject itemButton; 






    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventario>();

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < Inventory.slots.Length; i++)
            {
                if (Inventory.isFull[i] == false) // 

                {

                    //Agregar items 
                    Inventory.isFull[i] = true;
                    Instantiate(itemButton, Inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }





            }
        }
    }
}
