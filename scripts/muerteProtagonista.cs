using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerteProtagonista : MonoBehaviour
{
    private levelController archivoDeNivel;

    
    // Start is called before the first frame update
    void Start(){
        archivoDeNivel = FindObjectOfType<levelController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {    
        if (col.name == "p1_stand")
        {            
            archivoDeNivel.RespawnPlayer();
        }
    }
   
}
