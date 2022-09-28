using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
--- Hernández Salazar Diego Joan
--- GDGS2101
--- 1219100490
**/

public class CamController : MonoBehaviour
{
    public GameObject tanque;
    public Vector3 upCam = new Vector3(0,10,-10); //variable que guarda los vectores de la cámara
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //La cámara se transalada tomando en cuenta la posicion del tanque
        transform.position = tanque.transform.position + upCam;
    }
}
