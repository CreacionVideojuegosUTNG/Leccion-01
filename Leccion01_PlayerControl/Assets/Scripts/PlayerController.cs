using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
--- Hernández Salazar Diego Joan
--- GDGS2101
--- 1219100490
**/

public class PlayerController : MonoBehaviour
{
    public float velocidad = 1000;
    public float velGiro = 60;

    private float avanza; //variable para avanzar y retroceder
    private float gira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        avanza = Input.GetAxis("Vertical"); //extraemos el valor del teclado para avanzar y retrasar
        gira = Input.GetAxis("Horizontal"); //extraemos el valor del teclado para girar el objeto

        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza); //avanza hacia delante | tiempo | velocidad | Avanzar y Retrasar con el valor del mouse
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira); //realiza la rotación del objeto
    }
}
