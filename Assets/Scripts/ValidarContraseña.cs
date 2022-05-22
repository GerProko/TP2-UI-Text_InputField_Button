using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{

    string contraseñaCorrecta;
    string contraseñaUsuario;
    public Text ingresoUsuario;
    public Text textocartelito;
    public GameObject cartelitoMsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseñaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContraseña()
    {
        contraseñaUsuario = ingresoUsuario.text;
        if(contraseñaCorrecta==contraseñaUsuario)
        {
            cartelitoMsj.SetActive(true);
            textocartelito.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textocartelito.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
