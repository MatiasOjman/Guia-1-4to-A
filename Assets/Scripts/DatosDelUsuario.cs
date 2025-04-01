using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    public int edadUsuario;
    public float estaturaUsuario;
    public bool donante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("mi nombre es " + nombreUsuario + "tengo " + edadUsuario + " años " + "mido " + estaturaUsuario + " metros " + "donante " + donante);
       
               
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
