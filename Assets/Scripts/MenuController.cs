using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PointsController.maxScores[0] = PlayerPrefs.GetInt("MaxScore1", 0);
        PointsController.maxScores[1] = PlayerPrefs.GetInt("MaxScore2", 0);
        PointsController.maxScores[2] = PlayerPrefs.GetInt("MaxScore3", 0);
        PointsController.maxScores[3] = PlayerPrefs.GetInt("MaxScore4", 0);
        PointsController.maxScores[4] = PlayerPrefs.GetInt("MaxScore5", 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
