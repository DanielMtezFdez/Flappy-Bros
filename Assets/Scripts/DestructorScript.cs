using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorScript : MonoBehaviour {

    public GameObject environmentSpawner;
    public GameObject camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(camera.transform.position.x -25, 0, 10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Scenary")
        {
            environmentSpawner.SendMessage("GenerarEnvironment");
        }
        Destroy(collision.gameObject);
    }
}
