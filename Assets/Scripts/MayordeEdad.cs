using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayordeEdad : MonoBehaviour
{
    public int edad;
    public Text texto;

    // Start is called before the first frame update
    void Start()
    {
        if (edad >= 18)
        {
            texto.text = "Es mayor de edad";
        }
        else
        {
            texto.text = "No es mayor de edad";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
