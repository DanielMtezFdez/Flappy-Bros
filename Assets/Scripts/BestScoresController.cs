using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoresController : MonoBehaviour {

    public Text score1, score2, score3, score4, score5;

	// Use this for initialization
	void Start () {
        score1.text = PointsController.maxScores[0].ToString();
        score2.text = PointsController.maxScores[1].ToString();
        score3.text = PointsController.maxScores[2].ToString();
        score4.text = PointsController.maxScores[3].ToString();
        score5.text = PointsController.maxScores[4].ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
