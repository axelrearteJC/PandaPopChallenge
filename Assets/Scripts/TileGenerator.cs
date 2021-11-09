using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

   

    int mapWidht = 8;
    int mapHeight = 8;
    public Nodo[] misNodos;

    public float tileXOffset = 1.8f;
    public float tileZOffset = 1.45f;

    void Start()
    {
        CreateHexTileMap();
        FindNeighbors();
       
    }

    void CreateHexTileMap()
    {
        var hexagonosLista = Resources.LoadAll<GameObject>("Prefabs");

        for (int x = 0; x < mapWidht ; x++)
        {
            for (int z = 0; z < mapHeight; z++)
            {
                GameObject TempGo = Instantiate(hexagonosLista[Random.Range(0, hexagonosLista.Length)]);

                if(z % 2 == 0)
                {
                    TempGo.transform.position = new Vector3(x * tileXOffset, 0, z * tileZOffset);
                }else
                {
                    TempGo.transform.position = new Vector3(x * tileXOffset + tileXOffset / 2, 0, z * tileZOffset);
                }
            }
        }

        misNodos = GameObject.FindObjectsOfType<Nodo>();

    }
    //Algoritmo para agregar objetos a la lista "Vecinos"
    //TODO : Crear una funcion donde me encuentre objetos un al lado del otro
    void FindNeighbors()
    {
        for (int i = 0; i < misNodos.Length - 1; i++)
        {
            float distancia;
            for (int w = 0; w < misNodos.Length -1 ; w++)
            {
                distancia = Vector3.Distance(misNodos[i].transform.position, misNodos[w].transform.position);
                Debug.Log($"La distancia es {distancia} en el nodo {i} {misNodos[i]} y en el nodo {w} {misNodos[w]}");
                if (distancia < 1.5)
                {
                    misNodos[i].GetComponent<Nodo>().Vecinos.Add(misNodos[w]);
                }
            }
            /*
            if (misNodos[i].transform.position != misNodos[i+1].transform.position)
            {
                Vector3 asigno = misNodos[i].transform.position;
                Vector3 asigno2 = misNodos[i + 1].transform.position;
                if (Vector3.Distance(asigno,asigno2) < 2)
                {
                    misNodos[i].GetComponent<Nodo>().Vecinos.AddRange(misNodos);
                    Debug.Log($"La distancia es {Vector3.Distance(asigno, asigno2)}");
                }
            }
            */
            
        }
    }
}
