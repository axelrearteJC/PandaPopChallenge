using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects : MonoBehaviour
{

    public List<GameObject> hexagonosLista;
    // Start is called before the first frame update
    void Start()
    {
        hexagonosLista = new List<GameObject>(Resources.LoadAll<GameObject>("Prefabs"));
        
        Instantiate(hexagonosLista[4], new Vector3(8, 0, 7), Quaternion.identity);
        Instantiate(hexagonosLista[3], new Vector3(20, 11, 12), Quaternion.identity);
        
    }

}
