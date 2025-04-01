using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos : MonoBehaviour
{
    public int Num1;
    public int Num2;
    public int resultado;
    // Start is called before the first frame update
    void Start()
    {
         resultado = (Num1 + Num2);
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
