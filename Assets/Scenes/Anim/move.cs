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


    public float vida = 10.0f;
    public float Disparo = 20.0f;
    public float speed = 5.0f;


    static move instatiablePlayer;
    private void Awake()
    {
        instatiablePlayer = this;
    }

    public static move getInstance()
    {
        return instatiablePlayer;
    }

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

        anim.SetFloat("velocidadX", InputmovementX);
        anim.SetFloat("velocidadZ", InputmovementZ);

        if (Input.GetKeyDown(KeyCode.F)) 
         {
            Dance();
      //      StartCoroutine(noMove());
         }

    }
    void Dance ()
    {
        anim.SetBool("Dance",true);

    }

  //  IEnumerator noMove() 
  // {
   //     if (Input.GetKeyDown("f"))
    //    {
   //         StartCoroutine("Fade");
   //     }

  //  }
    void movimiento()
      {
        rb.velocity = new Vector3(InputmovementX * velocidad, rb.velocity.y, InputmovementZ * velocidad);
    }
}

