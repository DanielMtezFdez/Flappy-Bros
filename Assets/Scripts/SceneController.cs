using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void TerminarJuego()
    {
        Application.Quit();
    }
	
}
