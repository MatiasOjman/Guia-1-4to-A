using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientacion : MonoBehaviour
{
    public string nombreDeAlumno;
    public int year;
    public string especialidad;


    // Start is called before the first frame update
    void Start()
    {
        if (nombreDeAlumno == "" || year < 1 || year > 5)
        {
            Debug.Log("error");
            return;
        }
        else if (especialidad != "T" && especialidad != "M" && especialidad != "H" && especialidad != "G" && especialidad != "D")
        {
            Debug.Log("“Solo puede ingresar T, D, G, M o H”");
            return;
        }
       else if (year <3)
        {
            Debug.Log("“Error. Aún estás en el ciclo básico”");
            return;
        } else
        {
            Debug.Log("“Muchas gracias " + nombreDeAlumno + "”!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
