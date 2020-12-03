using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoController : MonoBehaviour
{

    public float velocidad;
    private playerController player;
    public GameObject particulaMuerteEnemigo;
    public float distanciaDisparo;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerController>();
        if(player.transform.localScale.x > 0)
        {
            velocidad = -velocidad;
        }

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidad, GetComponent<Rigidbody2D>().velocity.y);
        if (transform.position.x > player.transform.position.x + distanciaDisparo){
            //UnityEngine.Debug.Log("fireball position: "+GetComponent<Transform>().position.x+" --- player position: "+ player.GetComponent<Transform>().position.x);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemigo") {
            Instantiate(particulaMuerteEnemigo, col.transform.position, col.transform.rotation);
            Destroy(gameObject);
            Destroy(col.gameObject);

        }
    }
}
