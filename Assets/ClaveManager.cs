using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputClave;
    string claveIngresada;
    string clave;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = " ";
        clave = "Tati";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IngresarClave()
    {

        // Concatenar la clave con un mensaje diciendo si la clave es correcta o incorrecta

        claveIngresada = inputClave.text;
        if (claveIngresada == clave)
        {
            txtResultado.text = "Clave correcta";
        }
        else
        {
            txtResultado.text = "Clave incorrecta";
        }
    }
}