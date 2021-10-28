using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse Position: " + Input.mousePosition);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray))
            {
                Debug.Log("Le pegue a algo ");
            };
        }
        

        //No me sirve en modo de perspectiva
        //Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log("World Point: " + worldPoint);
        
        //Check for mouse click 
    }
}
