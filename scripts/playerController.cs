using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class playerController : MonoBehaviour{


    public float alturaSalto;
    public float velocidadMovimiento;

    //variables para saber si esta en el piso
    public Transform pisoCheck;
    public float pisoCheckRadio = 0.04f;
    public LayerMask pisoLayer;

    private bool enPiso;
    private bool dobleSalto;

    private Animator animacion;


    public Transform puntoDeDisparo;
    public GameObject bolaDeFuego;
    public int cantidadDeDisparos = 0;

    

    // Start is called before the first frame update
    void Start(){
        animacion = GetComponent<Animator>();
    }

    void FixedUpdate(){
        enPiso = Physics2D.OverlapCircle(pisoCheck.position, pisoCheckRadio, pisoLayer);
    }

    // Update is called once per frame
    void Update(){
       
        if (enPiso) {
            dobleSalto = false;
        }
        animacion.SetBool("grounded", enPiso);

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && enPiso){
            Salto();
        }
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && !dobleSalto && !enPiso){
            Salto();
            dobleSalto = true;
        }    

        //move right
        if (Input.GetKey(KeyCode.D)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);   
         
        }

        //move left
        if (Input.GetKey(KeyCode.A)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);   
         
        }   
        
        //shoot
        if (Input.GetKeyDown(KeyCode.M)){
            if (cantidadDeDisparos < 20) {
                Instantiate(bolaDeFuego, puntoDeDisparo.position, puntoDeDisparo.rotation);
                cantidadDeDisparos = cantidadDeDisparos + 1;
            }
        }

        animacion.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        if (GetComponent<Rigidbody2D>().velocity.x > 0) {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if(GetComponent<Rigidbody2D>().velocity.x < 0) {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    public void Salto(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, alturaSalto);
    }
}
