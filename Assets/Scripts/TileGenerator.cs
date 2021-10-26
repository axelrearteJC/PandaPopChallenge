using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

   

    int mapWidht = 8;
    int mapHeight = 8;

    public float tileXOffset = 1.8f;
    public float tileZOffset = 1.45f;

    void Start()
    {
        CreateHexTileMap();
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
    }
}
