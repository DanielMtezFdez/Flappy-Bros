using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip muerte;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        PointsController.puntos = 0;
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReproducirMuerteBird()
    {
        audioSource.clip = muerte;
        audioSource.loop = false;
        audioSource.Play();
    }

    public static int GetMaxScore()
    {
        return PlayerPrefs.GetInt("MaxScore1", 0);
    }

    public void SaveMaxScore()
    {
        ComprobarMaxScores();
        
        PlayerPrefs.SetInt("MaxScore1", PointsController.maxScores[4]);
        PlayerPrefs.SetInt("MaxScore2", PointsController.maxScores[3]);
        PlayerPrefs.SetInt("MaxScore3", PointsController.maxScores[2]);
        PlayerPrefs.SetInt("MaxScore4", PointsController.maxScores[1]);
        PlayerPrefs.SetInt("MaxScore5", PointsController.maxScores[0]);
    }


    private void ComprobarMaxScores()
    {
        if (PointsController.maxScores[4] < PointsController.puntos)
        {
            PointsController.maxScores[4] = PointsController.puntos;
        }

        Array.Sort(PointsController.maxScores);
    }
}
