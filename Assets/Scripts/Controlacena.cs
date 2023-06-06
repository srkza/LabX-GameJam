using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controlacena : MonoBehaviour
{

    public void Chamarcena(int cena)
    {
          SceneManager.LoadScene(cena);
    }

    public void Sair()
    {
        Application.Quit();
    }

}
