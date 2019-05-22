using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawnerController : MonoBehaviour {

    public GameObject environment;

	// Use this for initialization
	void Start () {
        StartCoroutine("GenerarEnvironment");
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    IEnumerator GenerarEnvironment()
    {

        while (true)
        {
            Vector3 vector3 = new Vector3(transform.position.x, -0.14f, 0);
            GameObject entorno = Instantiate(environment, vector3, environment.transform.rotation);

            Destroy(entorno, 12f);
            yield return new WaitForSeconds(3.6f);
        }
    }
}
