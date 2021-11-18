using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathFinding;

public class Nodo : MonoBehaviour, IAStarNode
{
    public int Costo;
    public List<Nodo> Vecinos = new List<Nodo>();
    

    //TODO: Agregar nodos a la lista "Vecinos".
   


    public IEnumerable<IAStarNode> Neighbours => Vecinos;

    public float CostTo(IAStarNode neighbour)
    {
        //Lo llama el getPath
        //Llamar nodo inicial y final
        //Calculo el costo
        //TODO : Con esta funcion tengo que devolver el costo de un nodo hasta "IAStarNode"
        //TODO : Cuanto le cuesta de ir desde un lugar a otro? Alrededor del "Cost"

        throw new System.NotImplementedException();
    }

    public float EstimatedCostTo(IAStarNode target)
    {
        //Costo estimado
        //Llamar nodo inicial y final
        //Retorna un numero
        throw new System.NotImplementedException();
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
