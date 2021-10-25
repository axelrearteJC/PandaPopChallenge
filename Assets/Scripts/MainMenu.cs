using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void CargarEscena()
    {
        Debug.Log("Cambio de escena?");
        SceneManager.LoadScene("Escena1");
        
    }
}
