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
    float cotizacionDolar = 1204.35f;
    float cotizacionEuro = 1541.11f;
    float cotizacionReal= 201.24f;
    float minimoAConvertir = 1000;
    // Start is called before the first frame update
    void Start()
    {
        //ingreso y validacion de datos

        if (montoAConvertir < minimoAConvertir )
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }

        if (codigoMoneda == "D")
        {
            cotizacionMoneda = cotizacionDolar ;

        }else if (codigoMoneda == "E")
        {
            cotizacionMoneda = cotizacionEuro ;

        }else if (codigoMoneda == "R")
        {
            cotizacionMoneda = cotizacionReal ;

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
