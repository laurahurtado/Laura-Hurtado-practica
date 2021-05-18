using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rb;
    public float velocidad = 1.0f;
    public float InputmovementZ;
    public float InputmovementX;
    public Animator anim;
    public bool noMove;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        InputmovementX = Input.GetAxis("Horizontal");
        InputmovementZ = Input.GetAxis("Vertical");

        movimiento();

        //  if ( InputmovementX != 0 || InputmovementZ !=0) // se crea una variable que nos indique que cuando este en cero no active la animacion de caminar 
        //  {
        //     anim.SetBool("estaCaminando", true);
        //  }
        // else
        //  {
        //     anim.SetBool("estaCaminando", false);

        //}

        

        anim.SetFloat("velocidadX", InputmovementX);
        anim.SetFloat("velocidadZ", InputmovementZ);

        if (Input.GetKeyDown(KeyCode.F)) 
       {
            Dance();
          
        }

    }
    void Dance ()
    {
        anim.SetBool("Dance",true);

    }

  //  IEnumerator noMove()
   // {
        
//
   // }

    void movimiento()
      {
        rb.velocity = new Vector3(InputmovementX * velocidad, rb.velocity.y, InputmovementZ * velocidad);
    }
}

