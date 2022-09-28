using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
--- Hernández Salazar Diego Joan
--- GDGS2101
--- 1219100490
**/


public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane; // variable que guarda un objeto con el nombre plane 
    private Vector3 offset = new Vector3(30,0,10);//punto 5 camara sigue al avión

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //con la propiedad transform transalada a la camara con la variable offset
        transform.position = plane.transform.position + offset ;
    }
}
