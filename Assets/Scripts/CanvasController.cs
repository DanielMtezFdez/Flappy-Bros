using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {
    
    public Text puntos;
    public Text puntosFinales;
    public Text maxScore;

	// Use this for initialization
	void Start () {
        maxScore.text = "Best score: " + GameController.GetMaxScore().ToString();
    }
	
	// Update is called once per frame
	void Update () {
        puntos.text = PointsController.puntos.ToString();
        puntosFinales.text = "Score: " + PointsController.puntos.ToString();
	}

    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}