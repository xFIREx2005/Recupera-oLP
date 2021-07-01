using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escala : MonoBehaviour
{
    //instancia a classe Vector que possibilita manipular as dimens�es
    public Vector3 scaleChange;





    // Start � chamado antes da atualiza��o do primeiro frame
    void Start()
    {

    }

    // Update � chamado a cada atualiza��o de frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float x = 0.001f;
            float y = 0.001f;
            float z = 0.001f;
            scaleChange.Set(x, y, z);
            Escala();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            float x = -0.001f;
            float y = -0.001f;
            float z = -0.001f;
            scaleChange.Set(x, y, z);
            Escala();
        }

    }

    void Escala()
    {

        transform.localScale += scaleChange;


    }

}