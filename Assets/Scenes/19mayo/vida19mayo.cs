using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida19mayo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            move.getInstance().vida++;
            Destroy(gameObject);
        }
    }

}
