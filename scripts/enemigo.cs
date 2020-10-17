using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public float velocidadMovimineto;
    public bool moverDerecha;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(moverDerecha)  {
                GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadMovimineto, GetComponent<Rigidbody2D>().velocity.y);
        } else {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadMovimineto, GetComponent<Rigidbody2D>().velocity.y);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
       if(col.tag == "limite" && moverDerecha==true)
        {
            moverDerecha = false;
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if(col.tag == "limite" && moverDerecha==false)
        {
            moverDerecha = true;
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (col.name == "p1_stand")
        {
            UnityEngine.Debug.Log("moristee...!!!!");
        }
    }
}
