using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour {


    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private AudioSource audioSource;

    public GameObject generadorEnvironment;
    public GameObject generadorColumnas;
    public GameObject gameController;
    public GameObject panel;
    public float velocidad;                                                     private bool isDead; 
    public float salto;

   

	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    public void Movement()
    {     
        if (isDead == false)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Fly");
                rigidbody2D.AddForce(new Vector2(0, salto));
                audioSource.Play();
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Limit")
        {
            rigidbody2D.velocity = Vector2.zero;
            isDead = true;
            animator.SetTrigger("Died");
            gameController.SendMessage("SaveMaxScore");
            Destroy(generadorColumnas);
            Destroy(generadorEnvironment);
            gameController.SendMessage("ReproducirMuerteBird");
            StartCoroutine("FinJuego");
        }
        
    }

    IEnumerator FinJuego()
    {
        yield return new WaitForSeconds(1f);
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}
