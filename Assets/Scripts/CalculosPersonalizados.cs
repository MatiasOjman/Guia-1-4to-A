using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float Num1;
    public float Num2;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resultado = Num2 + Num1;
        Debug.Log("El resultado de la suma entre " + Num1 + " y " + Num2 + " es " + resultado );
        resultado = Num2 - Num1;
        Debug.Log("El resultado de la resta entre " + Num1 + " y " + Num2 + " es " + resultado);
        resultado = Num2 * Num1;
        Debug.Log("El resultado de la multiplicacion entre " + Num1 + " y " + Num2 + " es " + resultado);
        resultado = Num2 / Num1;
        Debug.Log("El resultado de la division entre " + Num1 + " y " + Num2 + " es " + resultado);
    }
}
