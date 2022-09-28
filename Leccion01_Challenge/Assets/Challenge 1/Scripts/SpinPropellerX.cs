using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
--- Hernández Salazar Diego Joan
--- GDGS2101
--- 1219100490
**/

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    private float propeller = 1000;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Rotate(Vector3.forward, propeller * Time.deltaTime);
   
    }
}
