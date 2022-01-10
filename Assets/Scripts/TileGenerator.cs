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
    //TODO : Acceder al objeto nodo que se instancia TempoGo y luego hay que setearle un valor de CoordenadaX y CoordenadaY(seria Z)
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
                }
                else
                {
                    TempGo.transform.position = new Vector3(x * tileXOffset + tileXOffset / 2, 0, z * tileZOffset);
                    
                }

                var CoordenadaTileX = TempGo.transform.position.x;
                var CoordenadaTileZ = TempGo.transform.position.z;

            }
        }

        misNodos = GameObject.FindObjectsOfType<Nodo>();

    }

    //Algoritmo para agregar objetos a la lista "Vecinos"
    
    public void FindNeighbors()
    {
        for (int i = 0; i < misNodos.Length; i++)
        {
            float distancia;
            for (int w = 0; w < misNodos.Length; w++)
            {
                distancia = Vector3.Distance(misNodos[i].transform.position, misNodos[w].transform.position);
                if (distancia < 1.5 && distancia != 0)
                {
                    misNodos[i].GetComponent<Nodo>().Vecinos.Add(misNodos[w]);
                    
                }
            }
            
        }
    }
    
}
