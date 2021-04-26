using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2.0f;
    private float moveInputX;
    private float moveInputZ;
    public float jumpForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        moveInputX = Input.GetAxis("Horizontal");
        moveInputZ = Input.GetAxis("Vertical");
        movimiento();

    }
    

    

    void movimiento()
    {
        rb.velocity = new Vector3(moveInputX * speed, rb.velocity.y, moveInputZ * speed);

    }
}
