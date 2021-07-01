using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
public GameObject final;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Personagem")
        {
            Destroy(final);
            Destroy(this.gameObject);
        }
    }
}