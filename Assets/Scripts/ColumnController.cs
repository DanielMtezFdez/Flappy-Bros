using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnController : MonoBehaviour {

    public GameObject gameController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PointsController.puntos++;
            gameController.SendMessage("SaveMaxScore");
        }
    }
}
