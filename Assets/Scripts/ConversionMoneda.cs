using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionMoneda : MonoBehaviour
{
    //declaracion variables
    public float montoAConvertir;
    public string codigoMoneda;

    float cotizacionMoneda;

    float montoConvertido;
    // Start is called before the first frame update
    void Start()
    {
        //ingreso y validacion de datos

        if (montoAConvertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }

        if (codigoMoneda == "D")
        {
            cotizacionMoneda = 1204.35f;

        }else if (codigoMoneda == "E")
        {
            cotizacionMoneda = 1541.11f;

        }else if (codigoMoneda == "R")
        {
            cotizacionMoneda = 201.24f;

        }else
        {
            Debug.Log("Opcion de moneda extranjera no valida");
            return;
        }





        //procesamiento de datos

        montoConvertido = montoAConvertir / cotizacionMoneda;


        //salida de datos

        Debug.Log("monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
