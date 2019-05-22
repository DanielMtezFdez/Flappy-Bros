using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsSpawnController : MonoBehaviour {

    public GameObject column;
    public static bool generar;

	// Use this for initialization
	void Start () {
        StartCoroutine("GenerarColumnas");
        generar = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator GenerarColumnas()
    {
        yield return new WaitForSeconds(1f);

        while (generar)
        {
            Vector3 vector3 = new Vector3(transform.position.x, Random.Range(-1.5f, 4.5f), 0);
            Instantiate(column, vector3, column.transform.rotation);

            yield return new WaitForSeconds(1f);
        }
        
    }
}
