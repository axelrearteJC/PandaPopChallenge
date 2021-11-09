using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathFinding;

public class Nodo : MonoBehaviour, IAStarNode
{
    public int Costo;
    public List<Nodo> Vecinos = new List<Nodo>();
    

    //TODO: Agregar nodos a la lista "Vecinos".
    void EncontrarVecinos()
    {   
        
    }

    public IEnumerable<IAStarNode> Neighbours => Vecinos;

    public float CostTo(IAStarNode neighbour)
    {
        //Costo
        throw new System.NotImplementedException();
    }

    public float EstimatedCostTo(IAStarNode target)
    {
        //Costo estimado
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
