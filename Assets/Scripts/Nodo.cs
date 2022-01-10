using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathFinding;

public class Nodo : MonoBehaviour, IAStarNode
{
    public int Costo;
    public List<Nodo> Vecinos = new List<Nodo>();
    public int CoordenadaX;
    public int CoordenadaY;
       


    public IEnumerable<IAStarNode> Neighbours => Vecinos;
    
    public float CostTo(IAStarNode neighbour)
    {
        //Lo llama el getPath
        //Llamar nodo inicial y final
        //Casteo
        Nodo nodoVecino = (Nodo)neighbour;

        return nodoVecino.Costo;


        //Me tiene que devolver un float

        //Debug.Log("Valor es " + algo);

    }

   

    public float EstimatedCostTo(IAStarNode target)
    {
        //Costo estimado
        //Llamar nodo inicial y final
        //Retorna un numero

        Nodo nodoTarget = (Nodo)target;

        return 0;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //EncontrarVecinos();
        
    }
}
