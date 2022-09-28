using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
--- Hernández Salazar Diego Joan
--- GDGS2101
--- 1219100490
**/


public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20; //variable que guarda la velocidad
    public float rotationSpeed; //variable que guarda la rotacion
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //obtiene la entrada vertical del usuario
        verticalInput = Input.GetAxis("Vertical");

        //Mueve el avión hacia adelante a una velocidad constante este avanza forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);//agrege el * Time.deltaTime

        //inclina el avión hacia arriba/abajo según las teclas de flecha arriba/abajo
        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * verticalInput);//punto 3 listo

     
    }
}
