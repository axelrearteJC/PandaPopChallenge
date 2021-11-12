using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathFinding;

public class MouseDetect : MonoBehaviour
{
    public Nodo nodoInicio;
    public Nodo nodoFin;
    public bool buscarCamino; 
    
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if(buscarCamino)
        {
            buscarCamino = false;
            Debug.Log("Bool");
            //Camino desde nodo de inicio a nodo fin
            var camino = AStar.GetPath(nodoInicio, nodoFin);
            for (int i = 0; i < camino.Count; i++)
            {
              Debug.Log(camino[i]);
            }
        }

        if (Input.GetMouseButton(0))
        {

           // Debug.Log("Mouse Position: " + Input.mousePosition);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray))
            {
                //Debug.Log("Estoy tocando un hexagono y esta es la variable"  + ray);
               
            };
        }        
       
    }
}
